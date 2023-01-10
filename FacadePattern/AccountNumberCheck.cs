using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class AccountNumberCheck
    {
        private int _accountNumber = 12345678;
        public int GetAccountNumber() { return _accountNumber; }
        public bool AccountActive(int accountNumber)
        {
            if(accountNumber == GetAccountNumber())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
