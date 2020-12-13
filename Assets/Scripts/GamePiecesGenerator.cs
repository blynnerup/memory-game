using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GamePiecesGenerator : MonoBehaviour
{
    public GameObject gamePiece;
    public List<Sprite> pieceImages;

    private List<GameObject> gamePieces = new List<GameObject>();
    public Transform generatorPoint;
    public float xOffset = 2f;
    public float yOffset = 2f;

    private Dictionary<Sprite, int> usedImages = new Dictionary<Sprite, int>();
    // Start is called before the first frame update
    void Start()
    {
        //GameObject newPiece = Instantiate(gamePiece, generatorPoint.position, generatorPoint.rotation);

        //gamePieces.Add(newPiece);
        InstatiateImageDictionary();
        GeneratePieces();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void InstatiateImageDictionary()
    {
        foreach (Sprite sprite in pieceImages)
        {
            usedImages.Add(sprite, 0);
        }
    }

    private void GeneratePieces()
    {
        for (int i = 0; i < 10; i++)
        {
            bool notValidImage = false;
            Sprite pickedSprite;
            while (!notValidImage)
            {
                pickedSprite = GetSprite();
                if (usedImages[pickedSprite] < 2)
                {
                    usedImages[pickedSprite]++;
                    notValidImage = true;

                    GameObject newPiece = Instantiate(gamePiece, generatorPoint.position, generatorPoint.rotation);
                    newPiece.GetComponent<GamePieceLogic>().SetImage(pickedSprite);
                    newPiece.GetComponent<GamePieceLogic>().imageNumber = usedImages.Keys.ToList().IndexOf(pickedSprite);
                    generatorPoint.transform.position += new Vector3(xOffset, 0, 0);
                    gamePieces.Add(newPiece);
                }
            }
            if ((i + 1) % 5 == 0)
            {
                generatorPoint.transform.position = new Vector3(-7.5f, yOffset, 0);
            }
        }
    }

    private Sprite GetSprite()
    {
        // Get new image from pieces, check if used two times
        var randomNumber = Random.Range(0, pieceImages.Count);
        Sprite pickedSprite = pieceImages[randomNumber];
        return pickedSprite;
    }
}
