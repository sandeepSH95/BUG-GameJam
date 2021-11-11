using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_on_scroll : MonoBehaviour
{

    private Vector3 _rotation;
    [SerializeField] private float _speed;

    void Update()
    {   
        if(Input.GetKey(KeyCode.A)) _rotation = Vector3.up;
        else if (Input.GetKey(KeyCode.D)) _rotation = Vector3.down;
        else if (Input.GetKey(KeyCode.W)) _rotation = Vector3.left;
        else if (Input.GetKey(KeyCode.S)) _rotation = Vector3.right;
        else _rotation = Vector3.zero;

        transform.Rotate(_rotation * _speed * Time.deltaTime);
    }

}
