using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Dependency_Inversion_Principle_IdealCode;

class MailService
{
    public void SendMail(IMailServer mailServer, string to, string body)
    {
        mailServer.Send(to, body);
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
        //send mail...
    }
}

class Yandex : IMailServer
{
    public void Send(string to, string body)
    {
        //send mail...
    }
}

class Hotmail : IMailServer
{
    public void Send(string to, string body)
    {
        //send mail...
    }
}