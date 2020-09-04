using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Installers
{
    public static class InstallerExtensions
    {
        /// <summary>
        /// this static method does something very special, it will create an instance of each installer we have
        /// which are MvcInstaller and DbInstaller
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void InstallServicesInAssembly(this IServiceCollection services, IConfiguration configuration)
        {
            // this line is fancy as hell bro. Like it will create an array of the installers we got
            var installers = typeof(Startup).Assembly.ExportedTypes.Where(x =>
                typeof(IInstaller).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract).Select(Activator.CreateInstance).Cast<IInstaller>().ToList();

            // then we iterate throught he array of installers and call the Install the service based on our configuration
            installers.ForEach(installer => installer.InstallServices(services, configuration));
        }
    }
}
