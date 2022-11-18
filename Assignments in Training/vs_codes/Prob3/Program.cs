using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob3
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class InsufficientFuncException : System.Exception
    {
        private static readonly string DefaultMessage = "Account balance is insufficient for the transaction. ";
        public string TransactionAmount;
        public int AccountBalance;
        public int acc;

        public string Transactionamount{
            get;
            private set;
            }
        /*public InsufficientFuncException(string a, int n, int c)
        {
            TransactionAmount = a;
            AccountBalance = n;
            AccountBalance = c;


        }*/
    }
    class Amount
    {
        public int balance;

        public int Balance
        {
            get;
            private set;
        }
        public int Debit (int amount)
        {
            if(balance < amount)
            {
                throw new InsufficientFuncException();
            }
            else
            {
                return balance - amount;
            }
        }
    }
}
