using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using TrainWebApp.Domain;

namespace TrainWebApp.DependencyInjection
{
    public static class ContainerFactory
    {
        public static IContainer GetContainer(IConfiguration configuration)
        {
            return new GraceContainer(configuration);
        }
    }
}
