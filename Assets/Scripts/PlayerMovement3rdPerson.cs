using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement3rdPerson : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotateSpeed = 0.5f;
    public float jumpForce = 150.0f;
    public int rockQty = 0;

    public Text inventoryText;
    public GameObject projectile;
    public Transform spawnPoint;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        inventoryText.text = "Rock Quantity : " + rockQty;
        float rotateX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        transform.position += transform.forward * Time.deltaTime * speed * moveZ;
        transform.Rotate(rotateX * rotateSpeed * Vector3.up );

        if(Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if(Input.GetButtonDown("Fire1"))
        {
            if(rockQty > 0)
            {
                Instantiate(projectile, spawnPoint.position, spawnPoint.rotation);
            }
        }

    }

    public void AddRock(int qty)
    {
        rockQty += qty;
    }

}
