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
        var moveInputV = Input.GetAxis("Horizontal");
        
        
        //Set move velocity
        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(moveInputV * moveSpeed, myRigidbody.velocity.y, 0);

        //Get jump input
        //Preferably get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        //Apply jump force
        //Preferably interact with physics in FixedUpdate()
        if (jumpInput)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }


    }
}
