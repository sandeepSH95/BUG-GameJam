using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportCollision : MonoBehaviour
{
    //[SerializeField]
    //private bool isColliding = false;
    [SerializeField]
    private int numCollisions = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //isColliding = true;
        if(other.gameObject.CompareTag("adPlane") || other.gameObject.CompareTag("deter") || other.gameObject.CompareTag("security"))
        {
            return;

        } else
        {

            numCollisions++;
            //Debug.Log("isColliding " + this.name);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("adPlane") || other.gameObject.CompareTag("deter") || other.gameObject.CompareTag("security"))
        {
            return;

        }
        else
        {
            //isColliding = false;
            numCollisions--;
            //Debug.Log("isExiting " + this.name);
        }
        
    }

    public bool getCollisionStatus()
    {
        if (numCollisions == 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}
