using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] box;
    private float spawnRangeZ = 60f;
    private float spawnPosY = 60f;
    private float startDelay = 0.5f;
    private float spawnInterval =0.5f;
    private void Start()
    {  //giving an interval to bloes to spawn after some time
        InvokeRepeating("SpawnRandomBox", startDelay, spawnInterval);
    }

    // spawn boxes randomly
    void SpawnRandomBox()
    {
        int boxIndex = Random.Range(0,2);
        Vector3 spawnPos = new Vector3(0,spawnPosY,Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(box[boxIndex], spawnPos, box[boxIndex].transform.rotation);
    }
   
    
}
