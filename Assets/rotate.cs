using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{

    private Vector3 _rotation;
    [SerializeField] private float _speed;

    // Start is called before the first frame update
    public void Start()
    {
        _rotation = Vector3.up;
    }

    // Update is called once per frame
    public void Update()
    {
       transform.Rotate(_rotation * _speed * Time.deltaTime);
    }
}
