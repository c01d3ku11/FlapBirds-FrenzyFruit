﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterButton : MonoBehaviour
{
  void OnMouseDown() {
      SceneManager.LoadScene("gameScene");
  }
    
}
