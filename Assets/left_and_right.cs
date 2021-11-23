using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class left_and_right : MonoBehaviour
{
    public float speed;
    public int x_max;
    public int x_min;


    private Vector3 dir = Vector3.left;

    //Your Update function
    public void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.x <= x_max)
        {
            dir = Vector3.right;
        }
        else if (transform.position.x >= x_min)
        {
            dir = Vector3.left;
        }
    }

}
