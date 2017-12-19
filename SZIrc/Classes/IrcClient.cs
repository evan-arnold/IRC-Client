using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SZIrc.Forms;
namespace SZIrc
{
    public class IrcClient
    {
        #region Variables
        private string _server = "zoidberg.centralchat.net";
        private int _port = 6667;
        private string _channel = "#techlifeforum";
        private string _nick = "Guest";
        private string _altNick = "Guest";
        Form_RAW Raw = new Form_RAW();

        private TcpClient irc;
        private NetworkStream stream;
        private string inputLine;
        StreamReader reader;
        StreamWriter writer;
        #endregion

        #region Constructor
        public IrcClient(string Server, int Port)
        {
            _server = Server;
            _port = Port;
        }
        #endregion

        #region Properties
        public string Server
        {
            get { return _server; }
        }
        public int Port
        {
            get { return _port; }
        }
        public string Nick
        {
            get { return _nick; }
            set { _nick = value; }
        }
        public string AltNick
        {
            get { return _altNick; }
            set { _altNick = value; }
        }
        public string Channel
        {
            get { return _channel; }
            set { _channel = value; }
        }
        public bool Connected
        {
            get
            {
                if (irc != null)
                    if (irc.Connected)
                        return true;
                return false;
            }
        }
        #endregion

        #region Events
        public event UpdateUserListEventDelegate UpdateUsers;
        public event UserJoinedEventDelegate UserJoined;
        public event UserLeftEventDelegate UserLeft;
        public event UserNickChangeEventDelegate UserNickChange;

        public event ChannelMesssageEventDelegate ChannelMessage;
        public event NoticeMessageEventDelegate NoticeMessage;
        public event PrivateMessageEventDelegate PrivateMessage;
        public event ServerMessageEventDelegate ServerMessage;

        public event NickTakenEventDelegate NickTaken;

        public event DisconnectedEventDelegate Disconnected;
        #endregion

        #region PublicMethods
        /// Connect to the IRC Server and auto-join specific Channel
        public void Connect(string Channel)
        {
            try
            {
                _channel = Channel;
                irc = new TcpClient(_server, _port);
                stream = irc.GetStream();
                reader = new StreamReader(stream);
                writer = new StreamWriter(stream);

                Send("NICK " + _nick);
                Send("USER " + _nick + " 0 * :" + _nick);

                Listen();
                Variables.Connected = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was an error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Variables.Connected = false;
                return;
            }
        }// Connect(channel)

        // Connect to the IRC server and auto-join the default channel
        public void Connect()
        {
            Connect(_channel);
        }// Connect()

        public void Disconnect()
        {
            if (irc != null)
            {
                if (irc.Connected)
                {
                    Send("QUIT Client Disconnected");
                }
                irc = null;
                if (Disconnected != null)
                    Disconnected();
            }
        }

        // Send a notice to a user
        public void SendNotice(string Nick, string message)
        {
            Send("NOTICE " + Nick + " :" + message);
        }// SendNotice

        // Send a message to the channel
        public void SendMessage(string message)
        {
            Send("PRIVMSG " + _channel + " :" + message);
        }
        public void SendRAW(string message)
        {
            Send(message);
        }
        #endregion

        #region PrivateMethods
        // Listens for messages from the server
        private void Listen()
        {
            while ((inputLine = reader.ReadLine()) != null)
            {
                ParseData(inputLine);
            }//end while
        }

        // Parses data sent from the server
        private void ParseData(string data)
        {
            // debuggimg
            Raw.AddToRaw(data);

            // split the data into parts
            string[] ircData = data.Split(' ');

            // if the message starts with PING we must PONG back
            if (data.Length > 4)
            {
                if (data.Substring(0, 4) == "PING")
                {
                    Send("PONG " + ircData[1]);
                    return;
                }
            }

            // re-act according to the IRC Commands
            switch (ircData[1])
            {
                case "001": // server welcome message, after this we can join
                    Send("JOIN " + _channel);
                    Send("MODE " + _nick + " +B");
                    break;
                case "353": // member list
                    if (UpdateUsers != null)
                        UpdateUsers(JoinArray(ircData, 5).Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
                    break;
                case "433":
                    Console.WriteLine(ircData[3]);
                    if (NickTaken != null)
                        NickTaken(ircData[3]);

                    if (ircData[3] == _altNick)
                    {
                        Random rand = new Random();
                        string randomNick = "Guest" + rand.Next(0, 9) + rand.Next(0, 9) + rand.Next(0, 9);
                        Send("NICK " + randomNick);
                        Send("USER " + randomNick + " 0 * :" + randomNick);
                    }
                    else
                    {
                        Send("NICK " + _altNick);
                        Send("USER " + _altNick + " 0 * :" + _altNick);
                    }
                    break;
                case "JOIN": // someone joined
                    if (UserJoined != null)
                        UserJoined(ircData[0].Substring(1, ircData[0].IndexOf("!") - 1));
                    Send("NAMES " + _channel);
                    break;
                case "NICK":
                    if (UserNickChange != null)
                        UserNickChange(ircData[0].Substring(1, ircData[0].IndexOf("!") - 1), JoinArray(ircData, 3));
                    break;
                case "NOTICE": // someone sent a notice
                    if (NoticeMessage != null)
                        if (ircData[0].Contains("!"))
                        {
                            NoticeMessage(ircData[0].Substring(1, ircData[0].IndexOf('!') - 1),
                                JoinArray(ircData, 3));
                        }
                        else
                            NoticeMessage(_server, JoinArray(ircData, 3));
                    break;
                case "PRIVMSG": // message was sent to the channel or as private
                    // if it's a private message
                    if (ircData[2].ToLower() == _nick.ToLower())
                        PrivateMessage(ircData[0].Substring(1, ircData[0].IndexOf('!') - 1),
                            JoinArray(ircData, 3));
                    else
                        ChannelMessage(ircData[0].Substring(1, ircData[0].IndexOf('!') - 1),
                            JoinArray(ircData, 3));
                    break;
                case "PART":
                case "QUIT":// someone left
                    if (UserLeft != null)
                        UserLeft(ircData[0].Substring(1, data.IndexOf("!") - 1));
                    Send("NAMES " + _channel);
                    break;
                case "WHOIS":
                    
                    break;
                default:
                    // still using this while debugging
                    if (ServerMessage != null)
                    {
                        if (ircData.Length > 3)
                            ServerMessage(JoinArray(ircData, 3));
                    }
                    break;
            }
        }

        // Strips the message of unnecessary characters
        private string StripMessage(string message)
        {
            // remove IRC Color Codes
            foreach (Match m in new Regex((char)3 + @"(?:\d{1,2}(?:,\d{1,2})?)?").Matches(message))
                message = message.Replace(m.Value, "");

            // if there is nothing to strip
            if (message == "")
                return "";
            else if (message.Substring(0, 1) == ":" && message.Length > 2)
                return message.Substring(1, message.Length - 1);
            else
                return message;
        }

        // Joins the array into a string after a specific index
        private string JoinArray(string[] strArray, int startIndex)
        {
            return StripMessage(String.Join(" ", strArray, startIndex, strArray.Length - startIndex));
        }

        //Sending a message to the server.
        public void Send(string message)
        {
            writer.WriteLine(message);
            writer.Flush();
        }
        #endregion

    }

}
