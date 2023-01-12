using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class RealInternet : IInternet
    {
        public void ConnectTo(string host)
        {
            Console.WriteLine("Opened connection to " + host);
        }
    }
}
