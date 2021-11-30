using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReportTerrainCollision : MonoBehaviour
{
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

        if (other.gameObject.CompareTag("terrain") == false)
        {
            return;

        }
        else
        {

            numCollisions++;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("terrain") == false)
        {
            return;

        }
        else
        {

            numCollisions--;
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
