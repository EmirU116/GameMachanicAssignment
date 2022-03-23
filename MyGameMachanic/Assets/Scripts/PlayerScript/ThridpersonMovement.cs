using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class ThridpersonMovement : MonoBehaviour
{
    public CharacterController controller;      //Motor that drives our player
    public Vector3 movementVector = Vector3.zero;
    public float speed = 6f;        //Movement speed
    private Vector3 mVelocity;      //Movemnet
    public Vector3 moveDir;

    // Update is called once per frame
    void Update()
    {
        mVelocity = Vector3.zero;       //Cleaner code for Vector3(0,0,0)
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f,0f,speed*Time.deltaTime);        // Forward Movement
            mVelocity.z = 1.0f;
        } else if (Input.GetKey(KeyCode.S))     // Backward Movement
        {
            transform.Translate(0f,0f, -speed*Time.deltaTime);
            mVelocity.z = -1.0f;
        }

        if (Input.GetKey(KeyCode.D))        // Rotating to the right
        {
            transform.Rotate(0f, 120*Time.deltaTime, 0f);
        }else if (Input.GetKey(KeyCode.A))      //  Rotating to the left
        {
            transform.Rotate(0f, -120*Time.deltaTime, 0f);
        }
        
        transform.Translate(mVelocity.normalized * Time.deltaTime * speed);     // This code is for moving the same speed at any direction
    }
}
