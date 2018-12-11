using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace sw_pcs_core.Libraries
{
    public class AccountId
    {
        public static Int64 Convert(String Username)
        {
            var _hasher = MD5.Create();
            var _hashed = _hasher.ComputeHash(Encoding.UTF8.GetBytes(Username));
            return BitConverter.ToInt64(_hashed, 0);
        }
    }
}
