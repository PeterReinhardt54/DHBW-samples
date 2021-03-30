using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoF.Singelton
{
    public sealed class LoadBalancer
    {
        private static LoadBalancer _instance = new LoadBalancer();
        private List<string> _servers = new List<string>();
        private Random _random = new Random();

        private LoadBalancer()
        {
            // List of available servers
            _servers.Add("Server 1");
            _servers.Add("Server 2");
            _servers.Add("Server 3");
            _servers.Add("Server 4");
            _servers.Add("Server 5");
        }

        static LoadBalancer()
        {
        }

        public static LoadBalancer Instance
        {
            get
            {
                return _instance;
            }
        }

        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }

    }
}
