using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalls : MonoBehaviour
{
    [SerializeField] private GameObject[] ballPrefabsArray;
    private int ballIndex;

    private float spawnPosY = 23f;
    private float spawnRangeMax = 8f;
    private float spawnRangeMin = -38f;

    [SerializeField] private float startDelay = 2f;
    [SerializeField] private float spawnInterval = 1.5f;



    void Start()
    {
        InvokeRepeating("SpawnRandomBall",
             startDelay, spawnInterval);
    }

    private void SpawnRandomBall() 
    { 
        ballIndex = Random.Range(0, ballPrefabsArray.Length);
        Instantiate(ballPrefabsArray[ballIndex],
        RandomSpawnPos(),
        Quaternion.Euler(0, 23, 0));
    }

    private Vector3 RandomSpawnPos() 
    {
        float randomX = Random.Range(spawnRangeMin, spawnRangeMax);
        return new Vector3(randomX, spawnPosY, 0);
    }
    
}
