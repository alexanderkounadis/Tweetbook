using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tweetbook.Data;
using Tweetbook.Services;
using Microsoft.AspNetCore.Identity;

namespace Tweetbook.Installers
{
    public class DbInstaller : IInstaller
    {
        public void InstallServices(IConfiguration config, IServiceCollection services)
        {
            services.AddScoped<IPostService, PostService>();
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });
            services.AddIdentityCore<IdentityUser>().AddEntityFrameworkStores<DataContext>();
        }
    }
}
