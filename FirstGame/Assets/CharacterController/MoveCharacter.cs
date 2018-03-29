using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Things in "//" are original components that don't work w/ MovePattern Script added, non-// are for MovePattern only
public class MoveCharacter : MonoBehaviour {

	// public float speed = 6.0F;
    // public float jumpSpeed = 8.0F;
    // public float gravity = 20.0F;
    public MovePattern MovePattern;
    private CharacterController controller;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // private Vector3 moveDirection = Vector3.zero;
    void Update() {
        MovePattern.Move(controller, transform);
        
        // if (controller.isGrounded) {        
            // moveDirection.x = Input.GetAxis("Horizontal");
            // moveDirection.y = 0;
            // moveDirection.z = Input.GetAxis("Vertical");

            // moveDirection = transform.TransformDirection(moveDirection);
            // moveDirection *= speed;
            // if (Input.GetButton("Jump"))
                // moveDirection.y = jumpSpeed;
            
        // }
        // moveDirection.y -= gravity * Time.deltaTime;
        // controller.Move(moveDirection * Time.deltaTime);
    }
}
