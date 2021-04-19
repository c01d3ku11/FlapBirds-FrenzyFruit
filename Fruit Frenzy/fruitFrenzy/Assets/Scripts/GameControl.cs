using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public int score;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
       SetText();
    }

    void SetText()
    {
        scoreText.text = score.ToString();
    }

    public void AddPoints(int points)
    {
        score = score + points;
        SetText();
    }

    public void GameOver()
{
//save the score
//go to game over screen
}

    
}
