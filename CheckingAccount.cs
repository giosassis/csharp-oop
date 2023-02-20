using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class CheckingAccount
    {
        public int number_branch;
        public string account;
        public string owner;
        public double account_balance;

        public void Deposit(double value)
        {
            this.account_balance += value;
        }

        public void Withdrawal(double value)
        {
            if (value <= this.account_balance) { 
                this.account_balance -= value; 
            } 
            else {
                Console.WriteLine("Error"); 
            }
        } 
    }
}
