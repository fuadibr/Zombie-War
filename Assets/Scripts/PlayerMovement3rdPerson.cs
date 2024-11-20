using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3rdPerson : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotateSpeed = 1.5f;
    public float gravity = -9.81f;

    private CharacterController charControl;
    private Vector3 velocity;

    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        float rotateX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = transform.forward * moveZ;
        charControl.Move(move * speed * Time.deltaTime);

        transform.Rotate(rotateX * rotateSpeed * Vector3.up );

        velocity.y += gravity * Time.deltaTime;
        charControl.Move(velocity * Time.deltaTime);
    }
}
