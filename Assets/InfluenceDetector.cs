using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfluenceDetector : MonoBehaviour
{
    [SerializeField]
    private int influence;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("pawn"))
        {
            //influence++;
            //Debug.Log("inflience++ " + this.name);
            Destroy(collision.gameObject);
            

        }
    }


}
