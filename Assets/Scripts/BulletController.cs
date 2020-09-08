using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.tag == "MonsterDuck")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
            
    }
}
