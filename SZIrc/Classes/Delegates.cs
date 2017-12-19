using System;

namespace SZIrc
{
    public delegate void SaveSettingsEventDelegate();
    public delegate void UpdateUserListEventDelegate(string[] userlist);
    public delegate void UserJoinedEventDelegate(string user);
    public delegate void UserLeftEventDelegate(string user);
    public delegate void UserNickChangeEventDelegate(string oldUser, string newUser);

    public delegate void ChannelMesssageEventDelegate(string user, string message);
    public delegate void NoticeMessageEventDelegate(string user, string message);
    public delegate void PrivateMessageEventDelegate(string user, string message);
    public delegate void WhoisEventDelegate(string user, string message);

    public delegate void ServerMessageEventDelegate(string message);
    public delegate void NickTakenEventDelegate(string nick);

    public delegate void DisconnectedEventDelegate();
}