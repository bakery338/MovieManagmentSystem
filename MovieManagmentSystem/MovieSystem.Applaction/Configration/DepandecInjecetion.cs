using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Applaction.Configration
{
    public static class DepandecInjecetion
    {


        public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration configeration)
        {
            return services;
        }



    }
}
