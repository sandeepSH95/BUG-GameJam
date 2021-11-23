using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_and_down : MonoBehaviour
{
    public float speed;
    public int z_max;
    public int z_min;


    private Vector3 dir = Vector3.up;

    //Your Update function
    public void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.z <= z_max)
        {
            dir = Vector3.up;
        }
        else if (transform.position.z >= z_min)
        {
            dir = Vector3.down;
        }
    }

}