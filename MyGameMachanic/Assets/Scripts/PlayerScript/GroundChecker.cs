using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    /// <summary>
    /// This script is for checking if player is on the ground      
    /// </summary>
    public bool isGrounded { get; private set; }        // This is going to check if player is on ground or not

    [SerializeField] private float groundCheckLength = 1f;

    [SerializeField] private LayerMask groundLayers;
    
    void Update()
    {
        var ray = new Ray(transform.position, Vector3.down);
        isGrounded = Physics.Raycast(ray, groundCheckLength);
    }
}
