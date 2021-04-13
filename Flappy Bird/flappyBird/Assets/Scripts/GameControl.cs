﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public float score;
    public Text myText;
 

    // Update is called once per frame
    void Update()
    {
        score = score + Time.deltaTime;
        myText.text = score.ToString();
    }
    public void GameOver()
    {
        PlayerPrefs.SetFloat("playerScore", score);
    }
}
