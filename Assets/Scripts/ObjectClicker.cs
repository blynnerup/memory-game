using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    int? firstClickedNumber;
    GamePieceLogic firstGameObject;
    string[] gamePieces;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Left mouse being clicked
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.GetRayIntersection(Camera.main.ScreenPointToRay(Input.mousePosition));
            if (hit.collider != null)
            {
                Debug.Log(hit.collider.gameObject.name);
                var piece = hit.collider.GetComponent("GamePieceLogic") as GamePieceLogic;
                if (firstClickedNumber == null)
                {
                    firstClickedNumber = piece.imageNumber;
                    firstGameObject = piece;
                } 
                else
                {
                    if (firstClickedNumber == piece.imageNumber)
                    {
                        Debug.Log("Match");
                        piece.FoundMatch();
                        firstGameObject.FoundMatch();
                    }
                    else
                    {
                        Debug.Log("No Match");
                    }

                    firstClickedNumber = null;
                    firstGameObject = null;
                }
            }
            
        }
    }
}
