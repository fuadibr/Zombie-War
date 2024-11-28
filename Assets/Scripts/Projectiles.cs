using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float throwForce = 10.0f;
    private Rigidbody rb;

    public float radius = 10.0F;
    public float power = 500.0F;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Vector3 forceDirection = (transform.up + transform.forward) * throwForce;
        rb.AddForce(forceDirection, ForceMode.Impulse);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Vector3 explosionPos = transform.position;
            Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null) rb.AddExplosionForce(power, explosionPos, radius, 3.0F);
            }
            Destroy(gameObject);
        }
    }


}
