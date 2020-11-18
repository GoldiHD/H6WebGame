using H6WebGameAPI.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace H6WebGameAPI.Tools
{
    public class MapHandler
    {
        public void CreateMap()
        {
            SingleTon.MapCreationThread = new Thread((() => GenerateMap()));
            SingleTon.MapCreationThread.Start();
        }

        private void GenerateMap()
        {
            Map map = new Map();
            SingleTon.SetMapInstance(map);
        }
    }
}
