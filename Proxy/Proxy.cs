using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ProxyEs
{
    internal partial class Proxy
    {
        private Dictionary<string, Client> ConnectionIp;
        private static Proxy instance;
        private Proxy()
        {
            ConnectionIp = new Dictionary<string, Client>() { };
           
            Connetti(Utility.numbOfConnection);
             void Connetti(int i)
        {
                for (int j = 0; j < i; j++)
                    ConnectionIp.Add(serverId(), new Client());
                
        }
           
            stampaConnessioni(ConnectionIp);
         
        } 
        public static void Refresh()
            {
                ProxyInst().ConnectionIp.Clear();
                ProxyInst().ConnectionIp = new Dictionary<string, Client>();
            
            stampaConnessioni(ProxyInst().ConnectionIp);

            }
            
     
        public static Proxy ProxyInst()
        {
            if (instance == null)
                instance = new Proxy();
            return instance;
        }
        public static void stampaConnessioni(Dictionary<string,Client> bho)
        {
            foreach(var a in bho)
                Console.WriteLine($"Client: {a.Value._ip}\nServer {a.Key}\n");
        }
        
            static string serverId()
            {
                Server server = new Server();
                string a = server._ip;
                return a;
            }

            
        
        public class Server
        {
            public string _ip;
           
            public Server()
            {
                _ip = Utility.addIp();

            }

        }
        public class Client
        {
            public string _ip;
            public Client()
            {
                _ip = Utility.addIp();
            }


        }
    }
}




