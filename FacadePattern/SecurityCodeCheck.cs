using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class SecurityCodeCheck
    {
        private int _securityCode = 1234;
        public int GetsecurityCode() { return _securityCode; }
        public bool IsCodeCorrect(int securityCode)
        {
            if(securityCode == GetsecurityCode())
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
