using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectsDestroyer : MonoBehaviour
{
   private void OnCollisionEnter(Collision collision)
    {   // destroy game object when collide with other game object
        if(collision.gameObject.tag == "ClonesDestroyer" || collision.gameObject.tag == "ClonesDestroyer2")
        {
            Destroy(this.gameObject);

        }
    }
}
