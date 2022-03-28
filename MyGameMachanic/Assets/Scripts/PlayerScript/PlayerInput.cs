using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool JumpInput { get; private set; }
    public float MoveInput { get; private set; }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get jump input
        //Preferably get input in Update()
        JumpInput = Input.GetKeyDown(KeyCode.Space);

        //Get move Input
        //Preferably Get Input in Update()
        //Assigning the Horizontal Movement
        MoveInput = Input.GetAxis("Horizontal");
    }
}
