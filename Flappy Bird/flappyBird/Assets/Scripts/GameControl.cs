﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public float score;
    public Text myText;
    public GameObject bird;
    public GameObject pipe;
 

    // Update is called once per frame
    void Update()
    {
        //score = score + Time.deltaTime;
        //myText.text = score.ToString();
    }
   
    public void GameOver()
    {
        PlayerPrefs.SetFloat("playerScore", score);
        SceneManager.LoadScene("loseScene");
    }
}
