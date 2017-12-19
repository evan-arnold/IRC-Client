using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using SZIrc.Forms;

namespace SZIrc
{
    public partial class Form_Main : Form
    {
        #region Variables
        /*[DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAsAttribute(UnmanagedType.Bool)]
        static extern bool AllocConsole();*/

        Form_Settings setting = new Form_Settings();
        Form_RAW raw = new Form_RAW();
        private delegate void _UpdateUsers(string[] userlist);
        private delegate void _ShowMessage(string message);
        bool IsDarkTheme = true;
        IrcClient client;
        #endregion

        #region Base
        private void Button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button_Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        public Form_Main()
        {
            InitializeComponent();
            CheckHighlight();
        }
        #endregion

        #region Functions
        private void CheckTheme()
        {
            if (IsDarkTheme == true)
            {
                ToolStrip_Main_Tools_Button_Dark.Text = "• Dark";
                ToolStrip_Main_Tools_Button_Light.Text = "Light";
                RichTextBox_Chat.BackColor = Color.Black;
                RichTextBox_Chat.ForeColor = Color.White;
                ListBox_Users.BackColor = Color.Black;
                ListBox_Users.ForeColor = Color.White;
            }
            else
            {
                ToolStrip_Main_Tools_Button_Light.Text = "• Light";
                ToolStrip_Main_Tools_Button_Dark.Text = "Dark";
                RichTextBox_Chat.BackColor = Color.White;
                RichTextBox_Chat.ForeColor = Color.Black;
                ListBox_Users.BackColor = Color.White;
                ListBox_Users.ForeColor = Color.Black;
            }
        }
        private void SaveLog()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Text Files | *.txt";
            sfd.FilterIndex = 1;
            try
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter sw = File.CreateText(sfd.FileName);
                    for (int i = 0; i < RichTextBox_Chat.Lines.Length; i++)
                    {
                        sw.WriteLine(RichTextBox_Chat.Lines[i]);
                    }
                    sw.Flush();
                    sw.Close();
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage(ex.Message);
            }
        }
        static void HighlightPhrase(RichTextBox box, string phrase, Color color)
        {
            int pos = box.SelectionStart; string s = box.Text;
            for (int ix = 0; ; )
            {
                int jx = s.IndexOf(phrase, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0) break;
                box.SelectionStart = jx;
                box.SelectionLength = phrase.Length;
                box.SelectionColor = color;
                ix = jx + 1;
            }
            box.SelectionStart = pos; box.SelectionLength = 0;
        }
        private void Form_Main_Load(object sender, EventArgs e)
        {
            //AllocConsole();
        }
        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Disconnect();
        }
        private void ErrorMessage(string Text)
        {
            MessageBox.Show(Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void CheckHighlight()
        {
            try
            {
                Color Alert = ColorTranslator.FromHtml(TextBox_AlertColor.Text);
                Color Command = ColorTranslator.FromHtml(TextBox_CommandColor.Text);
                Color Message = ColorTranslator.FromHtml(TextBox_MessageColor.Text);
                Color PM = ColorTranslator.FromHtml(TextBox_PMColor.Text);
                HighlightPhrase(RichTextBox_Chat, "[!]", Alert);
                HighlightPhrase(RichTextBox_Chat, "[C]", Command);
                HighlightPhrase(RichTextBox_Chat, "[M]", Message);
                HighlightPhrase(RichTextBox_Chat, "[PM]", PM);
            }
            catch
            {
                ErrorMessage("One of the color values is incorrect, resetting...");
                TextBox_AlertColor.Text = "#FF0000";
                TextBox_CommandColor.Text = "#00FF15";
                TextBox_MessageColor.Text = "#00BFFF";
                TextBox_PMColor.Text = "#FFBB00";
                return;
            }
        }
        #endregion

        #region ControlFunctions
        private void TextBox_Port_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { } else { e.Handled = e.KeyChar != (char)Keys.Back; }
        }
        private void Button_SaveLog_Click(object sender, EventArgs e)
        {
            SaveLog();
        }
        private void RichTextBox_Chat_TextChanged(object sender, EventArgs e)
        {
            CheckHighlight();
        }
        private void TextBox_Message_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Button_Send.PerformClick();
                TextBox_Message.Focus();
            }
        }
        private void Button_Connection_Click(object sender, EventArgs e)
        {
                if (Variables.Nick == string.Empty || Variables.Name == string.Empty ||
                Variables.Server == string.Empty || Variables.Channel == string.Empty)
                {
                    ErrorMessage("Make sure all feilds are filled out in the settings menu."); //TODO: Check if port is set
                    return;
                }
                string server = Variables.Server, nick = Variables.Nick;
                int port = Variables.Port;
                if (client != null) 
                { 
                    Disconnect();
                    Variables.Connected = false;
                    return; 
                }
                client = new IrcClient(server, port); client.Nick = nick;
                AddEvents();
                Thread t = new Thread(Connect); t.IsBackground = true; t.Start();
                Button_Send.Enabled = true;
                RichTextBox_Chat.Text = string.Empty;
                Variables.Connected = true;
                if (Variables.Connected == true)
                {
                    Button_Connection.Text = "Disconnect";
                    //Make read only
                }
                else
                {
                    Button_Connection.Text = "Connect";
                    //Make non read only
                }
        }
        private void Button_Send_Click(object sender, EventArgs e)
        {
            if (CheckBox_Command.Checked == true && TextBox_Message.Text == "QUIT")
            {
                ErrorMessage("Please use the disconnect button to quit.");
                return;
            }
            if (CheckBox_Command.Checked == true)
            {
                client.Send(TextBox_Message.Text);
                ShowMessage("[C]" + client.Nick + " : " + TextBox_Message.Text);
                TextBox_Message.Clear(); TextBox_Message.Focus();
            }
            else
            {
                client.SendMessage(TextBox_Message.Text.Trim());
                ShowMessage("[M]<" + client.Nick + "> " + TextBox_Message.Text);
                TextBox_Message.Clear(); TextBox_Message.Focus();
            }
        }
        #endregion

        #region IRCFunctions
        private void Connect()
        {
            client.Connect(Variables.Channel);
        }
        private void Disconnect()
        {
            if (client != null) { client.Disconnect(); client = null; }
            ListBox_Users.Items.Clear(); Button_Connection.Text = "Connect";
        }
        private void AddEvents()
        {
            client.UpdateUsers += new UpdateUserListEventDelegate(UpdateUsers);
            client.UserJoined += new UserJoinedEventDelegate(UserJoined);
            client.UserLeft += new UserLeftEventDelegate(UserLeft);
            client.ChannelMessage += new ChannelMesssageEventDelegate(ChannelMessage);
            client.NoticeMessage += new NoticeMessageEventDelegate(NoticeMessage);
            client.PrivateMessage += new PrivateMessageEventDelegate(PrivateMessage);
            client.Disconnected += new DisconnectedEventDelegate(Disconnect);
        }
        private void UserJoined(string user) { ShowMessage("[!]" + user + " joined."); }
        private void UserLeft(string user) { ShowMessage("[!]" + user + " left."); }
        private void ChannelMessage(string user, string message) { ShowMessage("[M]<" + user + "> " + message); }
        private void NoticeMessage(string user, string message) { ShowMessage("[!]<" + user + "> " + message); }
        private void PrivateMessage(string user, string message) { ShowMessage("[PM]<" + user + "> " + message); }
        private void UpdateUsers(string[] userlist)
        {
            if (InvokeRequired) { this.Invoke(new _UpdateUsers(UpdateUsers), (object)userlist); return; }
            ListBox_Users.Items.Clear();
            foreach (string u in userlist) { ListBox_Users.Items.Add(u); }
        }
        private void ShowMessage(string message)
        {
            if (InvokeRequired) { this.Invoke(new _ShowMessage(ShowMessage), message); return; }
            RichTextBox_Chat.AppendText("\n" + message); RichTextBox_Chat.ScrollToCaret();
        }
        #endregion

        #region ToolStrip
        private void ToolStrip_AlertColor_DropDownClosed(object sender, EventArgs e)
        {
            CheckHighlight();
        }
        private void ToolStrip_Main_Tools_SaveLog_Click(object sender, EventArgs e)
        {
            SaveLog();
        }
        private void ToolStrip_Main_DropButton_Theme_Button_CommandColor_DropDownClosed(object sender, EventArgs e)
        {
            CheckHighlight();
        }
        private void ToolStrip_Main_DropButton_Theme_Button_MessageColor_DropDownClosed(object sender, EventArgs e)
        {
            CheckHighlight();
        }
        private void ToolStrip_Main_DropButton_Theme_Button_PMColor_DropDownClosed(object sender, EventArgs e)
        {
            CheckHighlight();
        }
        private void ToolStripButton_Dark_Click(object sender, EventArgs e) 
        { 
            IsDarkTheme = true; 
            CheckTheme(); 
        }
        private void ToolStripButton_Light_Click(object sender, EventArgs e) 
        { 
            IsDarkTheme = false; 
            CheckTheme(); 
        }
        private void ToolStrip_Main_Tools_Settings_Click(object sender, EventArgs e)
        {
            if (setting.IsDisposed)
            {
                setting = new Form_Settings();
                setting.Show();
            }
            else
            {
                setting.Show();
            }
        }

        private void ToolStrip_Main_Tools_RAW_Click(object sender, EventArgs e)
        {
            if (raw.IsDisposed)
            {
                raw = new Form_RAW();
                raw.Show();
            }
            else
            {
                raw.Show();
            }
        }
        #endregion
    }
}