using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAdInteraction : MonoBehaviour
{

    private float smooth = 1f;

    private Vector3 targetAngles;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseOver()
    {
        //Debug.Log("mouseover");
        if (Input.GetMouseButtonDown(0))
        {
            targetAngles = transform.eulerAngles + 180f * Vector3.up;

            transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime);
            Debug.Log("spun");

        }
    }
}
