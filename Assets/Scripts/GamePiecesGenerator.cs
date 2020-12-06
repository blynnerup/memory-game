using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePiecesGenerator : MonoBehaviour
{
    GameObject gamePiece;

    private List<GameObject> gamePieces = new List<GameObject>();
    public Transform generatorPoint;
    public float xOffset = 5;
    public float yOffset = 5;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newPiece = Instantiate(gamePiece, generatorPoint.position, generatorPoint.rotation);
        
        gamePieces.Add(newPiece);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
