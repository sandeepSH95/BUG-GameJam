using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazer_collider : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            Application.LoadLevel(0);
            print("ENTER");
        }
    }
}
