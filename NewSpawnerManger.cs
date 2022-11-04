using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewSpawnerManger : MonoBehaviour
{
    public GameObject spawnPoint1;
    public GameObject spawnPoint2;
    public GameObject spawnPoint3;
    public GameObject spawnPoint4;
    public GameObject spawnPoint5;

    public GameObject prefab;
    private int random;
    private float startDelay = 2f;
    private float spawnInterval = 3f;
    // Start is called before the first frame update
    void Start()
    { //giving an interval to blocks to spawn after some time
        InvokeRepeating("SpawnObject",startDelay, spawnInterval);
    }
    
    
    // giving range to spawn blocks and deactive any random block
    void SpawnObject()
    {
        random = Random.Range(1, 6);
        if(random == 1)
        {
            var first =Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            var fourth = Instantiate(prefab, spawnPoint4.transform.position, prefab.transform.rotation);
            var fifth = Instantiate(prefab, spawnPoint5.transform.position, prefab.transform.rotation);
            Destroy(first);
        }

        if(random == 2)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            var fourth = Instantiate(prefab, spawnPoint4.transform.position, prefab.transform.rotation);
            var fifth = Instantiate(prefab, spawnPoint5.transform.position, prefab.transform.rotation);
            Destroy(second);
        }

        if (random == 3)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            var fourth = Instantiate(prefab, spawnPoint4.transform.position, prefab.transform.rotation);
            var fifth = Instantiate(prefab, spawnPoint5.transform.position, prefab.transform.rotation);
            Destroy(third);
        }

        if (random == 4)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            var fourth = Instantiate(prefab, spawnPoint4.transform.position, prefab.transform.rotation);
            var fifth = Instantiate(prefab, spawnPoint5.transform.position, prefab.transform.rotation);
            Destroy(fourth);
        }

        if (random == 5)
        {
            var first = Instantiate(prefab, spawnPoint1.transform.position, prefab.transform.rotation);
            var second = Instantiate(prefab, spawnPoint2.transform.position, prefab.transform.rotation);
            var third = Instantiate(prefab, spawnPoint3.transform.position, prefab.transform.rotation);
            var fourth = Instantiate(prefab, spawnPoint4.transform.position, prefab.transform.rotation);
            var fifth = Instantiate(prefab, spawnPoint5.transform.position, prefab.transform.rotation);
            Destroy(fifth);
        }
    }
}
