using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float startTimeBtwSpawn;
    private float timeBtwSpawn;

    public Transform[] spawnPositions;
    public GameObject enemy;

    private void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            int randPos = Random.Range(0, spawnPositions.Length);
            Instantiate(enemy, spawnPositions[randPos].position, Quaternion.identity);
        } else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
