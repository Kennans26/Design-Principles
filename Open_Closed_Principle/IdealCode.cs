using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Open_Closed_Principle_IdealCode
{
    class MoneySender
    {
        public void Send(IMyBank bank, int amount, string accountNumber)
        {
            bank.TransferMoney(amount, accountNumber);
        }
    }

    interface IMyBank
    {
        bool TransferMoney(int amount, string accountNumber);
    }

    class SomeBank : IMyBank
    {
        public string? AccountNumber { get; set; }

        public void SendMoney(int amount)
        {
            //...
        }

        public bool TransferMoney(int amount, string accountNumber)
        {
            try
            {
                AccountNumber = accountNumber;
                SendMoney(amount);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class SomeBank2 : IMyBank
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

        public bool TransferMoney(int amount, string accountNumber)
        {
            try
            {
                SetDestinationAccountNumber(accountNumber);
                Send(amount);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }

    class SomeBank3 : IMyBank
    {
        public bool TransferMoney(int amount, string accountNumber)
        {
            throw new NotImplementedException();
        }
    }
}
