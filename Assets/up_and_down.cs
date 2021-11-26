using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_and_down : MonoBehaviour
{
    public float speed;
    public int y_max;
    public int y_min;


    private Vector3 dir = Vector3.forward;

    //Your Update function
    public void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.y <= y_min)
        {
            dir = Vector3.forward;
        }
        else if (transform.position.y >= y_max)
        {
            dir = Vector3.back;
        }
    }

}