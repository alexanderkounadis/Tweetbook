using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tweetbook.Installers
{
    public class GeneralApiInstaller : IInstaller
    {
        public void InstallServices(IConfiguration config, IServiceCollection services)
        {
            services.AddSwaggerGen();
        }
    }
}
