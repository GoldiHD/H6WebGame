using H6WebGameAPI.Entity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace H6WebGameAPI.Tools
{
    public class SingleTon
    {
        private static SQLAccessor SQLAccessorInstance;
        private static CryptoHashing CryptoHashingInstance;
        private static IConfiguration configurationInstance;
        public static Thread MapCreationThread;
        private static Map MapInstance;

        public static SQLAccessor GetSQLAccessor()
        {
            if (SQLAccessorInstance == null)
            {
                SQLAccessorInstance = new SQLAccessor();
            }
            return SQLAccessorInstance;
        }

        public static void SetMapInstance(Map newMap)
        {
            if(MapInstance != null)
            {
                MapInstance = newMap;
            }
        }

        public Map GetMap()
        {
            if(MapInstance == null || !MapCreationThread.IsAlive)
            {
                if(MapInstance != null)
                {
                    return MapInstance;
                }
            }
            return null;
        }

        public static string readSetting(string name)
        {
            return configurationInstance.GetSection("MySettings").GetSection(name).Value;
        }

        public static int readIntSetting(string name)
        {
            try
            {
                return Convert.ToInt32(configurationInstance.GetSection("MySettings").GetSection(name).Value);
            }
            catch
            {
                return 0;
            }
        }

        public static CryptoHashing GetCryptoHashing()
        {
            if (CryptoHashingInstance == null)
            {
                CryptoHashingInstance = new CryptoHashing();
            }
            return CryptoHashingInstance;
        }

        public static void SetIconfig(IConfiguration config)
        {
            configurationInstance = config;
        }
    }
}
