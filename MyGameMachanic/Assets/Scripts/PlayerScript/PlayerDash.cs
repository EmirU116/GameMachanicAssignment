using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : MonoBehaviour
{
    CharacterController playerController;
    
    public bool isDashing;

    private int dashAttempts;       //how many times you can dash
    private float dashStartingTime;     // When started dashing

    private CharacterController characterController;

    // Start is called before the first frame update
    void Start()
    {
        playerController.GetComponent<ThridpersonMovement>();
        characterController.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleDash();
    }

    void HandleDash()
    {
        bool isTryingToDash = Input.GetKeyDown(KeyCode.LeftShift);

        if (isTryingToDash && !isDashing)
        {
            if (dashAttempts <= 50)     // This is how many dashes i have
            {
                OnStartDash();
            }
        }

        if (isDashing)
        {
            if (Time.time - dashStartingTime <= 0.4f)       // If the dash time has not elapsed, it will continue to move player at 30f speed
            {
                if (playerController.movementVector.Equals(Vector3.zero))       
                {
                    // Player is not giving any input, just dash forward
                    characterController.Move(transform.forward * 30F * Time.deltaTime);     // Increasing the movement speed for a period of time
                }
                else
                {
                    characterController.Move(playerController.movementVector.normalized * 30f * Time.deltaTime);
                }
            }
            else
            {
                OnEndDash();
            }
        }
    }

    void OnStartDash()
    {
        
    }

    void OnEndDash()
    {
        
    }
}
