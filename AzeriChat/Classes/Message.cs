using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeriChat.Classes;
public class Message
{
    public string ? Username { get; set; }

    public TimeOnly ? Time { get; set; }

    public string ?Text { get; set; }

    public Message(string ? username , string ? text,TimeOnly time)
    {
        Username = username;
        Text = text;
        Time = time;
    }

    public Message() { }

}
