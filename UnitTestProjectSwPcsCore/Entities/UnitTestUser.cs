using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using sw_pcs_core.Libraries;
using sw_pcs_core.Entities;

namespace UnitTestProjectSwPcsCore.Entities
{
    [TestClass]
    public class UnitTestUser: BaseTest
    {
        [TestMethod]
        public async Task TestCreateUserAsync()
        {
            TestContext.User.AddRange(new User[] {
                new User { Name = "Loo Say Phoon",  Email = "sploo@outlook.com", Mobile = "+601127275481", AccountId = AccountId.Convert("sploo@outlook.com") }
            });

            TestContext.SaveChanges();

            var _results = await TestContext.User.ToListAsync();
           
           
        }
    }
}
