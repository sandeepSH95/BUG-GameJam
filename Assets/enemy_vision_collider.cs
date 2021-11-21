using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_vision_collider : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            print("ENTER");
        }
    }


    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("STAY");
        }
    }


    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            print("EXIT");
        }
    }
}
