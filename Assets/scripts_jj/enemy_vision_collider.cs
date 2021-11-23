using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_vision_collider : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "adPlane")
        {
            Destroy(other.gameObject);
            Application.LoadLevel(0);
            print("ENTER");
        }
    }
}
