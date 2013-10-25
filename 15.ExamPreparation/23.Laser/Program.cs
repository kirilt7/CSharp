using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laser
{
    class Laser
    {
        static int cubeWidth, cubeHeight, cubeDepth;

        static void Main(string[] args)
        {
            string[] cubeDimensions = Console.ReadLine().Split();

            cubeWidth = int.Parse(cubeDimensions[0]);
            cubeHeight = int.Parse(cubeDimensions[1]);
            cubeDepth = int.Parse(cubeDimensions[2]);

            bool[, ,] burnedCubes = new bool[cubeWidth, cubeHeight, cubeDepth];

            string[] startCoords = Console.ReadLine().Split();

            int posW = int.Parse(startCoords[0]),
                posH = int.Parse(startCoords[1]),
                posD = int.Parse(startCoords[2]);

            string[] directionComponents = Console.ReadLine().Split();

            int dirW = int.Parse(directionComponents[0]),
                dirH = int.Parse(directionComponents[1]),
                dirD = int.Parse(directionComponents[2]);

            while (true)
            {
                burnedCubes[posW - 1, posH - 1, posD - 1] = true;
                if (IsOutsideWidth(posW))
                {
                    dirW *= -1;
                }
                if (IsOutsideHeight(posH))
                {
                    dirH *= -1;
                }
                if (IsOutsideDepth(posD))
                {
                    dirD *= -1;
                }
                int nextW = posW + dirW,
                    nextH = posH + dirH,
                    nextD = posD + dirD;
                if (burnedCubes[nextW - 1, nextH - 1, nextD - 1] || IsOnEdge(nextW, nextH, nextD))
                {
                    break;
                }
                else
                {                        
                    posW = nextW;
                    posH = nextH;
                    posD = nextD;
                }
            }

            Console.WriteLine("{0} {1} {2}", posW, posH, posD);
        }
        private static bool IsOutsideWidth(int posW)
        {
            return posW == 1 || posW == cubeWidth;
        }

        private static bool IsOutsideHeight(int posH)
        {
            return (posH == 1 || posH == cubeHeight);
        }

        private static bool IsOutsideDepth(int posD)
        {
            return (posD == 1 || posD == cubeDepth);
        }

        private static bool IsOnEdge(int posW, int posH, int posD)
        {
            int count = 0;
            int[] array = new int[3];
            array[0] = posW;
            array[1] = posH;
            array[2] = posD;
            int[] cubeArray = new int[3];
            cubeArray[0] = cubeWidth;
            cubeArray[1] = cubeHeight;
            cubeArray[2] = cubeDepth;
            for (int i = 0; i < 3; i++)
            {
                if (array[i]==1 || array[i]==cubeArray[i])
                {
                    count++;  
                }
            }
            if (count>1)
            {
                return true;
            }
            else
	        {
                return false;
	        }
        }
    }
}