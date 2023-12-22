using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Loose_Coupling_InDependency;

class MailSender
{
    public void Send(IMailServer mailServer)
    {
        mailServer.Send("info.kennans26@gmail.com", "someone");
    }
}
interface IMailServer
{
    void Send(string to, string body);
}
class Gmail : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}
class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}
class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        //...
    }
}