using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePieceLogic : MonoBehaviour
{
    public int imageNumber;
    public bool removed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FoundMatch()
    {
        Destroy(gameObject);
    }
}
