using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lazer_collider : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);
            SceneManager.LoadScene ("LV3");
            print("ENTER");
        }
    }
}
