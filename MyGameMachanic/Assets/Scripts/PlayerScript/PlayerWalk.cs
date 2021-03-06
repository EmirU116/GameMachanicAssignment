using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerWalk : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;       // Field for position through physics simulation, also accesing the Rigidbody script
    [SerializeField] private float moveSpeed = 5f;        // Field for Movement
    [SerializeField] private PlayerInput PI;      // Accessing Manually another script
    [SerializeField] private float normalSpeed = 5f;

    public float dashCooldown;

    private PlayerInput Pi;

    [SerializeField] private float dashLenght = 10f;
    // Update is called once per frame
    void Update()
    {
        
        
        //Set move velocity
        //Preferably interact with physics in FixedUpdate()
        myRigidbody.velocity = new Vector3(PI.MoveInput * moveSpeed, myRigidbody.velocity.y, 0);
        
        // Dash Machanic Basic
        
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            
            if (Time.time >= 4 + dashCooldown)
            {
                //moveSpeed = 20F;
                transform.Translate(0,0,dashLenght * PI.MoveInput);
                dashCooldown = Time.time;
            }
                        
        }
        else
        {
            moveSpeed = normalSpeed;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 20f;
        }
    }
}
