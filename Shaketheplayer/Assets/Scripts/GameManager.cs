using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime;

    
    void Update()
    {


        if (timeBtwSpawn<=0)
        {
            int ran = Random.Range(0, obstaclePatterns.Length);

            Instantiate(obstaclePatterns[ran], transform.position, transform.rotation);
            timeBtwSpawn = startTimeBtwSpawn;
            if ( startTimeBtwSpawn>minTime)
            {
                startTimeBtwSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
        
    }
}
