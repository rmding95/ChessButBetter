
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChessButBetter
{
    public class Tile
    {
        public Unit Unit { get; set; }
        public int Length { get; set; }
        public int Width { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }

        public Tile(int x, int y)
        {
            xPos = x;
            yPos = y;
        }
    }
}