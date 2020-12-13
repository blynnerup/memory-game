using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static MemoryGameManager instance;
    public bool Player1Turn { get; set; }

    public void Awake()
    {
        instance = this;
    }
    void Start()
    {
        Player1Turn = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
