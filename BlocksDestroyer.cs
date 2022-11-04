using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlocksDestroyer : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ClonesDestroyer2")
        {
            Destroy(this.gameObject);

        }
    }
}
