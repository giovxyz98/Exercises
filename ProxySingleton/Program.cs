using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProxySingleton
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ExternalConnection externalConnection = new ExternalConnection(Utility.numbOfClient);

            do
            {
                externalConnection.Connections = Utility.TryAllConnections(externalConnection.getAllConnections());
                Utility.CheckTimePackages(externalConnection.getAllConnections());
                Proxy.GetInstance().showServers();
                Thread.Sleep(1000);
            } while (true);
        }


    }
}
