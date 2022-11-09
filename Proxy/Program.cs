using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ProxyEs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Proxy.ProxyInst();
            Thread.Sleep(1000);
            Proxy.Refresh();
        }
    }
}




