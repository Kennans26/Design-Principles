using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Open_Closed_Principle_NotIdealCode
{
    class MoneySender
    {
        public void Send(int amount)
        {
            //SomeBank bank = new();
            //bank.AccountNumber = "...";
            //bank.SendMoney(amount);
            
            SomeBank2 bank = new();
            bank.SetDestinationAccountNumber("123");
            bank.Send(amount);
        }
    }

    class SomeBank
    {
        public string? AccountNumber { get; set; }

        public void SendMoney(int amount)
        {
            //...
        }
    }

    class SomeBank2
    {
        string? _accountNumber;

        public void SetDestinationAccountNumber(string accountNumber)
        {
            //...
        }

        public void Send(int amount)
        {
            //...
        }
    }
}
