using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingController : MonoBehaviour { 

    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 5.0f;
    public float shootTimer = 0.5f;
    public float shootTimerIncrementor = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //shootTimer = Time.time;
        if (Time.time >= shootTimerIncrementor && Input.GetMouseButton(0))
        {
            Shoot();
            shootTimerIncrementor += shootTimer;
        }
    }

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.transform.up * bulletSpeed, ForceMode2D.Impulse);

        //Debug.Log(rb.position);
    }
}
