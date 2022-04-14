using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Data.EF
{
    public class ShopDbContextFactory : IDesignTimeDbContextFactory<ShopDBContext>
    {
        public ShopDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("ShopDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<ShopDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new ShopDBContext(optionsBuilder.Options);
        }
    }
}
