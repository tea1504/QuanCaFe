using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Configuration;

namespace QuanCaFe.Data.EF
{
    public class QuanCaFeDbContextFactory : IDesignTimeDbContextFactory<QuanCaFeDBContext>
    {
        public QuanCaFeDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var ConnectionString = configuration.GetConnectionString("QuanCaFeDb");
            var optionsBuilder = new DbContextOptionsBuilder<QuanCaFeDBContext>();
            optionsBuilder.UseSqlServer(ConnectionString);
            return new QuanCaFeDBContext(optionsBuilder.Options);
        }
    }
}
