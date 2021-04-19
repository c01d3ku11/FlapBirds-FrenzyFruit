using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float speed;
    public bool isDynamite;
    public int itemPoints;
    public GameControl myGame;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        myGame = GameObject.Find("GameManager").GetComponent<GameControl>();
       Spawn();
    }

   void Spawn()
   {
       transform.position = new Vector3(Random.Range(-4,4), Random.Range(-4,4),0);
       myRigid.velocity = Random.insideUnitCircle.normalized * speed;
   }
   void OnMouseDown()
{
if (isDynamite)
{
myGame.GameOver();
}
else
{
myGame.AddPoints(itemPoints);
Spawn();
}
}
}

