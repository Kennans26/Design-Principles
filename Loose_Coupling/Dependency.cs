using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Loose_Coupling_Dependency;

class MailSender
{
    public void Send()
    {
        //Gmail gmail = new();
        //gmail.Send("info.kennans26@gmail.com");
        Hotmail hmail = new();
    }
}
class Gmail
{
    public Gmail()
    {

    }

    public void Send(string to)
    {
        //...
    }
}
class Hotmail
{
    public Hotmail()
    {
        
    }

    public void Send(string to)
    {
        //...
    }
}