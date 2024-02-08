using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
    public float speed = 5f;
    private Rigidbody rb;

    void Start () 
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void FixedUpdate () 
    {
        // Check for input and move the player accordingly
        float moveHorizontal = Input.GetAxis("Horizontal"); // Gets input from A/D or left/right arrow keys
        float moveVertical = Input.GetAxis("Vertical"); // Getw input from W/S or up/down arrow keys

        // Calculates the movement based on the input
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement = movement.normalized * speed * Time.deltaTime;

        // Move the player using physics
        rb.MovePosition(transform.position + movement);
    }
}
