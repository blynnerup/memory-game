using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour
{
    int? firstClickedNumber;
    GamePieceLogic firstGameObject;
    public Sprite flask;
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
                var piece = hit.collider.GetComponent("GamePieceLogic") as GamePieceLogic;
                if (firstClickedNumber == null)
                {
                    firstClickedNumber = piece.imageNumber;
                    firstGameObject = piece;
                    piece.ShowSprite();
                } 
                else
                {
                    if (firstClickedNumber == piece.imageNumber)
                    {
                        Debug.Log("Match");
                        UIController.instance.Player1Matched();
                        StartCoroutine(MatchWaiter(piece));
                    }
                    else
                    {
                        Debug.Log("No match");
                        StartCoroutine(Waiter(piece));
                    }
                }
            }
            
        }
    }
    
    private IEnumerator Waiter(GamePieceLogic piece)
    {
        piece.ShowSprite();
        yield return new WaitForSeconds(2);
        piece.ShowSprite();
        firstGameObject.ShowSprite();

        firstClickedNumber = null;
        firstGameObject = null;
    }

    private IEnumerator MatchWaiter(GamePieceLogic piece)
    {
        piece.ShowSprite();
        yield return new WaitForSeconds(2);

        piece.FoundMatch();
        firstGameObject.FoundMatch();

        firstClickedNumber = null;
        firstGameObject = null;
    }
}
