using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Dependency_Inversion_Principle_NotIdealCode;

class MailService
{
    public void SendMail(Gmail gmail)
    {
        gmail.Send("...");
    }
}

class Gmail
{
    public void Send(string mail)
    {
        //send mail...
    }
}
class Yandex
{
    public void SendMail(string mail, string to)
    {
        //send mail...
    }
}
class Hotmail
{
    public void Send(string mail)
    {
        //send mail...
    }
}