using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidbody;

    public float jumpforce = 100f;

    private void Update()
    {

        //Get jump input
        //Preferably get input in Update()
        var jumpInput = Input.GetKeyDown(KeyCode.Space);
        
        //Apply jump force
        //Preferably interact with physics in FixedUpdate()
        if (jumpInput)
        {
            myRigidbody.AddForce(Vector3.up * jumpforce);
        }
    }
}
