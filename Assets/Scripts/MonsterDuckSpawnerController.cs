using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterDuckSpawnerController : MonoBehaviour
{
    public GameObject enemy;
    private float randX;
    private float randY;
    private Vector2 whereToSpawn;
    public float spawnRate = 2f;
    private float nextSpawn = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            randX = Random.Range(13f, 25f);
            randY = Random.Range(7f, -8f);
            whereToSpawn = new Vector2(randX, randY);
            Instantiate(enemy, whereToSpawn, Quaternion.identity);
        }
    }
}
