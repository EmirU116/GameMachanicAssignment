using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;       // Field for position through physics simulation
    
    [SerializeField] private float jumpForce = 500f;      // Field for Jumping    

    [SerializeField] private PlayerInput playerInput;

    [SerializeField] private GroundChecker gc;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        //Apply jump force
        //Preferably interact with physics in FixedUpdate()
        if (playerInput.JumpInput && gc.isGrounded)
        {
            myRigidbody.AddForce(Vector3.up * jumpForce);
        }
    }
}
