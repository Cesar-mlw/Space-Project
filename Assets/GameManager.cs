using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject asteroids;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnAsteroid", 1f, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SpawnAsteroid()
    {
        Instantiate(asteroids, RandomAsteroidSpawn(), new Quaternion(0f, 0f, 0f, 0f));
    }
    
    private Vector3 RandomAsteroidSpawn()
    {
        Vector3 location = new Vector3(Random.Range(-20f, 20f), Random.Range(-10f, 10f), 120f);
        return location;
    }
}
