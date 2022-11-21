using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ProjectConfiguration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder().AddJsonFile("appconfig.json").Build();
            Settings settings = config.GetRequiredSection("settings").Get<Settings>();

        }
        public class Settings
        {
            public string SMTP { get; set; }
            public string POP { get; set; }
        }
    }
}
