using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public Text player1Score;
    public Text player2Score;

    public void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        player1Score.text = "0";
        player2Score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Player1Matched()
    {
        var player1CurrentScore = int.Parse(player1Score.text);
        player1CurrentScore++;
        player1Score.text = player1CurrentScore.ToString();
    }

    public void Player2Matched()
    {
        var player2CurrentScore = int.Parse(player2Score.text);
        player2CurrentScore++;
        player1Score.text = player2CurrentScore.ToString();
    }
}
