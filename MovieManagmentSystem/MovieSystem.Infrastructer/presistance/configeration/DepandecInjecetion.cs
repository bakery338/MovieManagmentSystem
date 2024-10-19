using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSystem.Infrastructer.presistance.configeration
{
    public  static class DepandecInjecetion
    {
        public static IServiceCollection AddInfrastrucerService( this IServiceCollection services , IConfiguration configeration)
        {
            return services;
        }

       
        //====================

        public static WebApplication UseInfrastructerServices(this WebApplication app)
        {
            return app;

        }
        //===================================





    }
}
