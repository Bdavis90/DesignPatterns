using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class FundsCheck
    {
        private double _cashInAccount = 1000.00;
        public double GetCashInAccount() { return _cashInAccount; }
        public void DecreaseCashInAccount(double cashWithdrawn)
        {
            _cashInAccount -= cashWithdrawn;
        }

        public void IncreaseCashInAccount(double cashDeposit)
        {
            _cashInAccount += cashDeposit;
        }

        public bool HaveEnoughMoney(double cashToWithdrawal)
        {
            if(cashToWithdrawal > GetCashInAccount())
            {
                Console.WriteLine("Error: You don't have enough money");
                Console.WriteLine("Current Balance " + GetCashInAccount());

                return false;
            }
            else
            {
                DecreaseCashInAccount(cashToWithdrawal);
                Console.WriteLine("Withdrawal Complete: Current Balance " + GetCashInAccount());

                return true;
            }
        }

        public void MakeDeposit(double cashToDeposit)
        {
            IncreaseCashInAccount(cashToDeposit);
            Console.WriteLine("Deposit Complete: Current Balace is " + GetCashInAccount());
        }
    }
}
