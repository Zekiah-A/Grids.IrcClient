using System;

//namespace IrcClient;

public class UpdateUsersEventArgs : EventArgs
{
    public UpdateUsersEventArgs(string channel, string[] userList)
    {
        Channel = channel;
        UserList = userList;
    }

    public string Channel { get; internal set; }
    public string[] UserList { get; internal set; }
}

public class UserJoinedEventArgs : EventArgs
{
    public UserJoinedEventArgs(string channel, string user)
    {
        Channel = channel;
        User = user;
    }

    public string Channel { get; internal set; }
    public string User { get; internal set; }
}

public class UserLeftEventArgs : EventArgs
{
    public UserLeftEventArgs(string channel, string user)
    {
        Channel = channel;
        User = user;
    }

    public string Channel { get; internal set; }
    public string User { get; internal set; }
}

public class ChannelMessageEventArgs : EventArgs
{
    public ChannelMessageEventArgs(string channel, string from, string message)
    {
        Channel = channel;
        From = from;
        Message = message;
    }

    public string Channel { get; internal set; }
    public string From { get; internal set; }
    public string Message { get; internal set; }
}

public class NoticeMessageEventArgs : EventArgs
{
    public NoticeMessageEventArgs(string from, string message)
    {
        From = from;
        Message = message;
    }

    public string From { get; internal set; }
    public string Message { get; internal set; }
}

public class PrivateMessageEventArgs : EventArgs
{
    public PrivateMessageEventArgs(string from, string message)
    {
        From = from;
        Message = message;
    }

    public string From { get; internal set; }
    public string Message { get; internal set; }
}

public class UserNickChangedEventArgs : EventArgs
{
    public UserNickChangedEventArgs(string oldNick, string newNick)
    {
        Old = oldNick;
        New = newNick;
    }

    public string Old { get; internal set; }
    public string New { get; internal set; }
}

public class StringEventArgs : EventArgs
{
    public StringEventArgs(string s)
    {
        Result = s;
    }

    public string Result { get; internal set; }

    public override string ToString()
    {
        return Result;
    }
}

public class ExceptionEventArgs : EventArgs
{
    public ExceptionEventArgs(Exception x)
    {
        Exception = x;
    }

    public Exception Exception { get; internal set; }

    public override string ToString()
    {
        return Exception.ToString();
    }
}

public class ModeSetEventArgs : EventArgs
{
    public ModeSetEventArgs(string channel, string from, string to, string mode)
    {
        Channel = channel;
        From = from;
        To = to;
        Mode = mode;
    }

    public string Channel { get; internal set; }
    public string From { get; internal set; }
    public string To { get; internal set; }
    public string Mode { get; internal set; }
}