using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAdBehaviour : MonoBehaviour
{
    private bool isLooking;
    private Transform targetTransform;

    // Start is called before the first frame update
    void Start()
    {
        isLooking = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isLooking)
        {
            transform.LookAt(targetTransform, Vector3.up);
        }
    }

    public void LookAt(Transform other)
    {
        Debug.Log("lookat");

        targetTransform = other;

        isLooking = true;
    }

    public void StopLooking()
    {
        Debug.Log("stoplooking");

        isLooking = false;
    }

    void survey()
    {

    }
}
