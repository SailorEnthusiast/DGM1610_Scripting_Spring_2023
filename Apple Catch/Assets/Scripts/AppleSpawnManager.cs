using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleSpawnManager : MonoBehaviour
{
    public GameObject[] applePrefabs;
    public float spawnRangeX = 17.0f;
    public float spawnPosZ;

    private float startDelay = 2f;
    private float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomApple",startDelay,spawnInterval);
    }

    void SpawnRandomApple()
    {
        // Generate a position to spawn at on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX,spawnRangeX),0,spawnPosZ);
         // Pick a random apple from the array
        int enemyIndex = Random.Range(0,applePrefabs.Length);
        //Spawn the apple indexed from the array
        Instantiate(applePrefabs[enemyIndex],spawnPos,applePrefabs[enemyIndex].transform.rotation);
    }
}
