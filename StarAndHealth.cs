using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarAndHealth : MonoBehaviour
{
    public GameObject Star;
    public GameObject Health;
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    private float spawnPosY = 48f;
    private float spawnRangeZ = 40f;

    private int random;
    // Start is called before the first frame update
    void Start()
    {
        //giving an interval to stars and hearts to spawn after some time
        InvokeRepeating("SpawnStarAndHealth", 2f, 5f);
        InvokeRepeating("SpawnStarAndHealth2", 2f, 5f);
    }

     // Randomly spawning star and heart at spawn point 1
    void SpawnStarAndHealth()
    {
        random = Random.Range(0, 2);
        if (random == 1)
        {

            var star = Instantiate(Star, spawnPoint1.transform.position, Star.transform.rotation);
            star.SetActive(true);
        }
        else
        {
            var heart = Instantiate(Health, spawnPoint1.transform.position, Health.transform.rotation);
            heart.SetActive(true);
        }

    }
    // Randomly spawning star and heart at spawn point 2
    void SpawnStarAndHealth2()
    {
        random = Random.Range(0, 2);
        if (random == 1)
        {

            var star = Instantiate(Star, spawnPoint2.transform.position, Star.transform.rotation);
            star.SetActive(true);

        }
        else
        {
            var heart = Instantiate(Health, spawnPoint2.transform.position, Health.transform.rotation);
            heart.SetActive(true);
        }

    }

}