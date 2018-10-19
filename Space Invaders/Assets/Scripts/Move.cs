using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 5.0f;
    
    void Update()
    {

        //poruszanie sie
        var move = new Vector3(Input.GetAxis("Horizontal"), 0);
        transform.position += move * speed * Time.deltaTime;
        if ((transform.position.x > 9.5)||(transform.position.x < -9.5))
        {
            transform.position -= move * speed * Time.deltaTime;
        }
    }
}
