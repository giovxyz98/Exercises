using System;
using System.Collections.Generic;

namespace ProxyEs
{
    internal class Proxy
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
        public static class Utility
        {
            public static Random random = new Random();
            public static int minRangeIP=0;
            public static int maxRangeIP=255;
            public static int numbOfConnection=100;
            public static string GeneraIp(int minRangeIP, int maxRangeIP)
            {
                string Ip = ($"{random.Next(minRangeIP, maxRangeIP)}.{random.Next(minRangeIP, maxRangeIP)}.{random.Next(minRangeIP, maxRangeIP)}.{random.Next(minRangeIP, maxRangeIP)}");
                return Ip;
            }
            public static string addIp()
            {
                string _ip;
                _ip = Utility.GeneraIp(0, 255);

                return _ip;



            }
        }
    }
}




