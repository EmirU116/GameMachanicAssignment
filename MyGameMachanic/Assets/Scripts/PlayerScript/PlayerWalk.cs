using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;       // Field for position through physics simulation, also accesing the Rigidbody script
    [SerializeField] private float moveSpeed = 5f;        // Field for Movement

    [SerializeField] private PlayerInput PI;      // Accesing Manually another script
    

    // Update is called once per frame
    void Update()
    {
        //Set move velocity
        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(PI.moveInputH * moveSpeed, myRigidbody.velocity.y, 0);
        myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, 0, PI.moveInputV * moveSpeed);
    }
}
