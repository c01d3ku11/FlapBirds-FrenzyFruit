using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemControl : MonoBehaviour
{
    public Rigidbody2D myRigid;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
       Spawn();
    }

   void Spawn()
   {
       transform.position = new Vector3(Random.Range(-4,4), Random.Range(-4,4),0);
       myRigid.velocity = Random.insideUnitCircle.normalized * speed;
   }
}
