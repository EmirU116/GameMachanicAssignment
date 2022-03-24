using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody myRigidbody;       // Field for position through physics simulation
    public float moveSpeed = 5f;        // Field for Movement
    public float jumpForce = 500f;      // Field for Jumping         

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get move Input
        //Preferably Get Input in Update()
        //Assigning the Horizontal Movement
        var moveInput = Input.GetAxis("Vertical");

        myRigidbody.velocity = new Vector3(0, myRigidbody.velocity.y, moveInput * moveSpeed);
    }
}
