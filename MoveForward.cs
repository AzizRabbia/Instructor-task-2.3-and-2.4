using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{  
    public float rangeA = 55;
    public float rangeB = -50;

    // Update is called once per frame
    void Update()
    {

        // moving player left and right and giving a range
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(0f, 0f, 1f);
            if(transform.position.z > rangeA)
            {
                transform.position = new Vector3(1f, 11f, 55f);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.position -= new Vector3(0f, 0f, 1f);
            if (transform.position.z < rangeB)
            {
                transform.position = new Vector3(1f, 11f, -50f);
            }
        }
        
      
    }
    
}
