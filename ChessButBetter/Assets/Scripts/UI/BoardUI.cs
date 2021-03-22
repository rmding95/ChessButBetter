using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ChessButBetter
{
    public class BoardUI : MonoBehaviour
    {
        public GameObject tilePrefab;
        // Start is called before the first frame update
        void Start()
        {
            generateBoard();
        }

        // // Update is called once per frame
        // void Update()
        // {

        // }

        void generateBoard()
        {
            int length = 5;
            int width = 5;
            int xPos = 0;
            int yPos = 0;
            Board board = new Board(length, width);
            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Tile tile = board.getTile(row, col);
                    Instantiate(tilePrefab, new Vector2(xPos, yPos), Quaternion.identity);
                    Debug.Log("Created new gameobject at " + xPos + ", " + yPos);
                    xPos += 10;
                    Debug.Log("Row: " + row + " Col: " + col);
                }
                xPos = 0;
                yPos += 10;
            }
        }
    }
}