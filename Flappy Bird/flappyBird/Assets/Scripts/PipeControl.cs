using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public float speed;
public float destroyPos = -12;
   
public GameControl gameControl;
void Start() {
    gameControl = GameObject.Find("Game Control").GetComponent<GameControl>();
}
    // Update is called once per frame
    void Update()
    {
       transform.position = transform.position + Vector3.left * speed * Time.deltaTime;
       if(transform.position.x < destroyPos){
           GameObject.Destroy(gameObject);
           gameControl.score++;
           gameControl.myText.text = gameControl.score.ToString();
       } 
    }
}
