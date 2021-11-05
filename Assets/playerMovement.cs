using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    private Rigidbody rigidBodyComponent;

    private float horizontalInput;
    private float verticalInput;
    [SerializeField]
    private float playerSpeed = 4.0f;

    // Start is called before the first frame update
    void Start()
    {
        rigidBodyComponent = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Vertical");
        verticalInput = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        rigidBodyComponent.velocity = new Vector3(horizontalInput * playerSpeed, rigidBodyComponent.velocity.y, 0);
        rigidBodyComponent.velocity = new Vector3(verticalInput * playerSpeed, 0, rigidBodyComponent.velocity.x);
    }
}
