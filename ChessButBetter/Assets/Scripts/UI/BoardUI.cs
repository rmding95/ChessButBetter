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
        Camera cam;
        // Start is called before the first frame update
        void Start()
        {
            cam = Camera.main;
            generateBoard();
        }

        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit2D hit = Physics2D.Raycast(cam.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
                if (hit.collider != null)
                {
                    Debug.Log("Hit " + hit.collider.gameObject.name);
                }
            }    
        }

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
                    square.name = row + ", " + col;
                    square.transform.localScale = new Vector3(squareSize, squareSize, 0);
                    squareRenderers[row, col] = square.GetComponent<SpriteRenderer>();
                    squareRenderers[row, col].color = Color.yellow;
                    BoxCollider2D collider = square.GetComponent<BoxCollider2D>();
                    collider.size = new Vector2(1, 1);
                    xPos += squareSize + 0.2f;
                }
                xPos = 0;
                yPos += squareSize + 0.2f;
            }
        }
    }
}