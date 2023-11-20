using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.PlayerSettings;

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
        Quaternion.Euler(90, 0, 0));
    }

    private void BallsInBounds() 
    {
        //Limite por la izquierda
        if (pos.x < -xRange) 
        {
            transform.position = new Vector3(-xRange, pos.y, pos.z);
        }

        // Limite por la derecha
        {
            transform.position = new Vector3(xRange, pos.y, pos.z);
        }
    }

    private Vector3 RandomSpawnPos() 
    {
        float randomX = Random.Range(spawnRangeMin, spawnRangeMax);
        return new Vector3(randomX, spawnPosY, 0);
    }
    
}
