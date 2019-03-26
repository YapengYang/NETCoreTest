using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NETCoreTest.BusinessCore
{
    public class ConfigExtensions
    {
        public static IConfiguration Configuration { get; set; }

        static ConfigExtensions()
        {
            //ReloadOnChange = true 当appsettings.json被修改时重新加载            
            Configuration = new ConfigurationBuilder()
                .Add(new JsonConfigurationSource { Path = "appsettings.json", ReloadOnChange = true })
                .Build();
        }

    }
}
