using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    public float gravity = -9.81f;
    public float jumpHeight = 2.0f; //added for jumping mechanic

    private CharacterController charControl;
    private Vector3 velocity;
    private bool isGrounded; //added for jumping mechanic

    void Start()
    {
        charControl = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        //added for jumping mechanic
        isGrounded = charControl.isGrounded;
        
        if(isGrounded && velocity.y < 0.0f)
        {
            velocity.y = -2.0f;
        }

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        
        if(isGrounded && Input.GetButton("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * gravity * -2.0f);
        }

        velocity.y += gravity * Time.deltaTime;
        charControl.Move(move * speed * Time.deltaTime + velocity * Time.deltaTime);
    }
}
