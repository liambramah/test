using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubiksCube
{
    public class RubikCube
    {
        private Dictionary<string, CubeFace> Faces { get; set; }

        public RubikCube(int cubeSize)
        {
            // initialize all faces in solved state

            Faces = new Dictionary<string, CubeFace>();

            Faces.Add("F", new CubeFace("F", cubeSize, TileColor.Green));
            Faces.Add("R", new CubeFace("R", cubeSize, TileColor.Red));
            Faces.Add("U", new CubeFace("U", cubeSize, TileColor.White));
            Faces.Add("B", new CubeFace("B", cubeSize, TileColor.Blue));
            Faces.Add("L", new CubeFace("L", cubeSize, TileColor.Orange));
            Faces.Add("D", new CubeFace("D", cubeSize, TileColor.Yellow));

        }

        public void RotateCubeFace(string faceName, RotationDirection direction)
        {
            if (!Faces.ContainsKey(faceName))
            {
                throw new InvalidOperationException(faceName + " is not a valid Face name");
            }
        }
    }
}
