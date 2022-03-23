using System.Collections;
using System.Collections.Generic;
using System.Security;
using UnityEngine;

public class ThridpersonMovement : MonoBehaviour
{
    public CharacterController controller;      //Motor that drives our player

    public float speed = 6f;        //Movement speed
    private Vector3 mVelocity;

    // Update is called once per frame
    void Update()
    {
        mVelocity = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0f,0f,speed*Time.deltaTime);
            mVelocity.z = 1.0f;
        } else if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f,0f, -speed*Time.deltaTime);
            mVelocity.z = -1.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0f, 120*Time.deltaTime, 0f);
        }else if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0f, -120*Time.deltaTime, 0f);
        }
        
        transform.Translate(mVelocity.normalized * Time.deltaTime * speed);
    }
}
