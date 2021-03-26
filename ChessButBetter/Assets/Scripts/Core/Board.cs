

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ChessButBetter
{
    public class Board
    {
        public int length { get; set; }
        public int width { get; set; }
        public Square[,] squares;

        public Board(int xlength, int ywidth)
        {
            length = xlength;
            width = ywidth;
            squares = new Square[length, width];
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Square square = new Square(row, col);
                    squares[row, col] = square;
                }
            }
        }

        public Square getSquare(int x, int y)
        {
            return squares[x, y];
        }
    }
}