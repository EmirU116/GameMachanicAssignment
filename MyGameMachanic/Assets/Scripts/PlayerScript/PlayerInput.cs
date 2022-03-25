using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    public bool jumpInput;
    public float moveInputV;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get jump input
        //Preferably get input in Update()
        jumpInput = Input.GetKeyDown(KeyCode.Space);

        //Get move Input
        //Preferably Get Input in Update()
        //Assigning the Horizontal Movement
        moveInputV = Input.GetAxis("Horizontal");
    }
}
