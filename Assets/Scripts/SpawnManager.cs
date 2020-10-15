using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ballPrefabs;
    public float spawnX = 95;
    public float spawnZ = 50;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnBall", startDelay, spawnInterval);
        
    }

    // Update is called once per frame
    void Update()
    {
     

        
    }
    void SpawnBall()
    {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnX, spawnX), 0, spawnZ);
        int ballIndex = Random.Range(0, ballPrefabs.Length);

        Instantiate(ballPrefabs[ballIndex], spawnPos, ballPrefabs[ballIndex].transform.rotation);
    }
}
