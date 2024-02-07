using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
{
	public float speed = 5f;
	
	void Start () 
	{
		// Use this for initialization
	}
	
	void FixedUpdate () 
	{
		// Check for input and move the player accordingly
        float moveHorizontal = Input.GetAxis("Horizontal"); // Get input from A/D or left/right arrow keys
        float moveVertical = Input.GetAxis("Vertical"); // Get input from W/S or up/down arrow keys

        // Calculates the movement direction based on the input
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

        // Normalize the movement vector to prevent faster diagonal movement
        movement.Normalize();

        // Move the player using Rigidbody physics
        GetComponent<Rigidbody>().velocity = movement * speed;
	}
}
