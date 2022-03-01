using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    public class CubeFace
    {
        public string FaceName { get; set; }

        public Tile[,] Tiles { get; set; }

        public CubeFace(string faceName, int cubeSize, TileColor tileColor)
        {
            FaceName = faceName ?? throw new ArgumentNullException(nameof(faceName));
            Tiles = new Tile[cubeSize, cubeSize];

            // iitialize all tiles with the same color.

            for (int i = 0; i <= Tiles.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= Tiles.GetUpperBound(1); j++)
                {
                    Tiles[i, j].TileColor = tileColor;
                }
            }
        } 

        public void SetTileColor(int tileYIndex, int tileXIndex, TileColor color)
        {
            // check if array index are valid.. 
            if (tileXIndex < 0 || tileYIndex < 0)
            {
                throw new ArgumentOutOfRangeException("Tile indexes cannot be negative values..");
            }
            else if (tileXIndex > Tiles.GetUpperBound(1) || tileYIndex > Tiles.GetUpperBound(0))
            {
                throw new ArgumentOutOfRangeException("Tile indexes cannot be greater than 2..");
            }
            else
            {
                Tiles[tileYIndex, tileXIndex].TileColor = color;
            }
        }
    }
}
