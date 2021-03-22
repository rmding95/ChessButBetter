

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChessButBetter
{
    public class Board
    {
        public int length { get; set; }
        public int width { get; set; }
        public Tile[,] tiles;

        public Board(int xlength, int ywidth)
        {
            length = xlength;
            width = ywidth;
            tiles = new Tile[length, width];
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Tile tile = new Tile(row, col);
                    tiles[row, col] = tile;
                }
            }
        }

        public Tile getTile(int x, int y)
        {
            return tiles[x, y];
        }
    }
}