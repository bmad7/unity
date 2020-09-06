using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.name == "Monster(duck)")
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
            
    }
}
