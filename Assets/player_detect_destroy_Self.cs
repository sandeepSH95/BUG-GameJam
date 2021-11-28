using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_detect_destroy_Self : MonoBehaviour

{
    [Header("Paticle System")]
    public ParticleSystem EnemyDeath;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "adPlane")
        {
            Destroy(gameObject);
            Instantiate(EnemyDeath, transform.position, Quaternion.identity);
            print("ENTER");
        }
    }
}
