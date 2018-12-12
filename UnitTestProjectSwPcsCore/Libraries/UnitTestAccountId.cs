using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;

using System;
using System.Collections;
using System.Collections.Generic;

using sw_pcs_core.Libraries;

namespace UnitTestProjectSwPcsCore.Libraries
{
    [TestClass]
    public class UnitTestAccountId
    {
        [TestMethod]
        public void TestAccountId()
        {
            SortedList<string, Int64> _accountList = new SortedList<string, Int64>()
            {
                {"sploo@emyralsystems.com", 2310164391714063678},
                {"bstang@emyralsystems.com", 3319232815535447622},
                {"thomas.li@emyralsystems.com", 2784652845355988010},
                {"test@emyralsystems.com", 827854384385604798}
            };

            foreach (KeyValuePair<string, Int64> _account in _accountList)
            {
                Logger.LogMessage($"{_account.Key} => {AccountId.Convert(_account.Key)}");
                Assert.AreEqual(_account.Value, AccountId.Convert(_account.Key));

            }
        }
    }
}
