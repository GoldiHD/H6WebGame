using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Tools
{
    public class SingleTon
    {
        private static SQLAccessor SQLAccessorInstance;
        private static CryptoHashing CryptoHashingInstance;

        public static SQLAccessor GetSQLAccessor()
        {
            if(SQLAccessorInstance == null)
            {
                SQLAccessorInstance = new SQLAccessor();
            }
            return SQLAccessorInstance;
        }

        public static string readSetting(string name)
        {
            return "";
        }

        public static CryptoHashing GetCryptoHashing()
        {
            if(CryptoHashingInstance == null)
            {
                CryptoHashingInstance = new CryptoHashing();
            }
            return CryptoHashingInstance;
        }

    }
}
