using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stare : MonoBehaviour
{

    private bool isLooking;
    private Transform lookingAt;

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
            transform.LookAt(lookingAt, Vector3.up);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "AdBroadcast")
        {
            Debug.Log("seen");

            isLooking = true;

            lookingAt = other.transform;            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isLooking = false;
        Debug.Log("stopped looking");
    }

}
