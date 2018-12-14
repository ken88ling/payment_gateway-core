using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;

using sw_pcs_core;
using sw_pcs_core.Entities;
using sw_pcs_core.Libraries;

namespace UnitTestProjectSwPcsCore.Entities
{
    public class BaseTest
    {
        protected readonly CoreContext TestContext = null;

        public BaseTest()
        {
            var _options = new DbContextOptionsBuilder<CoreContext>()                
                .UseInMemoryDatabase("UnitTestProjectSwPcsCore")
                .Options;
           
            TestContext = new CoreContext(_options);
            TestContext.Database.EnsureDeleted();
            TestContext.Database.EnsureCreated();
        }
    }
}
