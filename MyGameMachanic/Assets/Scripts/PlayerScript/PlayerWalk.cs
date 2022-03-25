using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    public Rigidbody myRigidbody;       // Field for position through physics simulation, also accesing the Rigidbody script
    public float moveSpeed = 5f;        // Field for Movement

    public PlayerInput PI;      // Accesing Manually another script
    

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
    }
}
