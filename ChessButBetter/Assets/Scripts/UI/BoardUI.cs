using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ChessButBetter
{
    public class BoardUI : MonoBehaviour
    {
        public GameObject squarePrefab;
        public SpriteRenderer[, ] squareRenderers;
        public int squareSize;
        public int boardLength;
        public int boardWidth;
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
            float xPos = 0.0f;
            float yPos = 0.0f;
            Board board = new Board(boardLength, boardWidth);
            squareRenderers = new SpriteRenderer[boardLength, boardWidth];
            for (int row = 0; row < boardLength; row++)
            {
                for (int col = 0; col < boardWidth; col++)
                {
                    // Instantiate is a shortcut to creating gameobjects if you have prefabs
                    // Without instantiate, you could create an object like GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Quad) for a basic square object
                    GameObject square = Instantiate(squarePrefab, new Vector2(xPos, yPos), Quaternion.identity);
                    square.transform.localScale = new Vector3(squareSize, squareSize, 0);
                    squareRenderers[row, col] = square.GetComponent<SpriteRenderer>();
                    squareRenderers[row, col].color = Color.yellow;
                    xPos += squareSize + 0.2f;
                }
                xPos = 0;
                yPos += squareSize + 0.2f;
            }
        }
    }
}