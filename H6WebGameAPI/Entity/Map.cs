using H6WebGameAPI.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace H6WebGameAPI.Entity
{
    public class Map
    {
        public Tile[,] Tiles;
        private List<Tile> TileTypes = new List<Tile>();

        public Map()
        {
            TileTypes.Add(new Tile() { name = "GrassField",  });//create more tiles
            int xSize = SingleTon.readIntSetting("MapXSize");
            int ySize = SingleTon.readIntSetting("MapYSize");
            Random rng = new Random();
            Tiles = new Tile[xSize, ySize];
            for(int y = 0; y < ySize; y++)
            {
                for(int x = 0; x < xSize; x++)
                {
                    Tile randomTile = TileTypes[rng.Next(0, TileTypes.Count)];
                    Tiles[x,y] = new Tile { name = randomTile.name, description = randomTile.description, baseItems = randomTile.baseItems, enemies = randomTile.enemies, imageName = randomTile.imageName, Xcord = x, ycord = y };
                }
            }
        }
    }
}
