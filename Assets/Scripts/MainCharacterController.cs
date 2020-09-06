using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCharacterController : MonoBehaviour { 

    public float movementSpeed = 2.0f;
    public Rigidbody2D charRigidBody;
    public Transform characterAimingDirection;
    private Vector2 moveInput;


    // Update is called once per frame
    void Update()
    {

        // Change char position
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");
        charRigidBody.velocity = moveInput * movementSpeed;

        // Char aiming direction
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(
            mousePosition.x - transform.position.x,
            mousePosition.y - transform.position.y
        );

        transform.up = direction;


    }
}
