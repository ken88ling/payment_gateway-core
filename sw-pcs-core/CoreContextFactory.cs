using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace sw_pcs_core
{
    public class CoreContextFactory : IDesignTimeDbContextFactory<CoreContext>
    {
        public CoreContext CreateDbContext(string[] args)
        {
            var _optionsBuilder = new DbContextOptionsBuilder<CoreContext>();
            
            _optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SwPCSCoreDB;Trusted_Connection=True;Application Name=PaymentCardSystem;");

            return new CoreContext(_optionsBuilder.Options);            
        }
    }
}
