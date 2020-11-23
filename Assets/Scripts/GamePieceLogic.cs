using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePieceLogic : MonoBehaviour
{
    public int imageNumber;
    public bool removed;
    public bool flipped;
    public Sprite backart;
    public Sprite image;

    // Start is called before the first frame update
    void Start()
    {
        flipped = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FoundMatch()
    {
        Destroy(gameObject);
    }

    public void ShowSprite()
    {
        var sr = gameObject.GetComponent<SpriteRenderer>();
        if (!flipped)
        {
            sr.sprite = image;
            flipped = true;
            return;
        }
        if (flipped)
        {
            sr.sprite = backart;
            flipped = false;
            return;
        }
    }
}
