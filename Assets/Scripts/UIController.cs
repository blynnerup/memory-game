using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Text player1Score;
    public Text player2Score;

    private int p1score = 0;
    private int p2score = 0;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player1Score.text = "Player 1: 0";
        player2Score.text = "Player 2: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1Matched()
    {
        p1score++;
        player1Score.text = "Player 1: " + p1score.ToString();
    }

    public void Player2Matched()
    {
        p2score++;
        player2Score.text = "Player 2: " + p2score.ToString();
    }
}
