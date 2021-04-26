using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
PlayerPrefs.SetInt("userScore", score);
SceneManager.LoadScene("loseScene");
}

    
}
