using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour
{
    public GameObject heart;
    public GameObject star;
    private int StarCount = 0;
    public HealthManager hm;

    private void OnCollisionEnter(Collision collision)
    {   // Controlling Health Count and Star Count
        if(collision.gameObject.tag == "Star")
        {
            StarCount++;
            print("Star Count : " + StarCount);
        }

        if (collision.gameObject.tag == "Heart")
        {
            //Reference from Health Manager Script

            hm.health = hm.health + 4;
            print("Health Count : " + hm.health);
        }
    }
}
