using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    //Initializing and Handling Health
    public int health = 20;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            health--;
            if (health < 0)
            {
                print("Game Over");
                Time.timeScale = 0; 
            }
            print(health);
        }
    }
}
