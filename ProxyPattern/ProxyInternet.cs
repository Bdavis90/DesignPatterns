using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    public class ProxyInternet : IInternet
    {
        private static List<string> bannedSites;
        private RealInternet internet = new RealInternet();

        public ProxyInternet()
        {
            bannedSites = new List<string> { "banned.com"};
        }
        public void ConnectTo(string host)
        {
            if(bannedSites.Contains(host))
            {
                Console.WriteLine("Access Denied!");
                return;
            }

            internet.ConnectTo(host);
        }
    }
}
