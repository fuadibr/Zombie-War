using UnityEngine;

public class Pickup : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerMovement3rdPerson>().AddRock(1);
            Destroy(gameObject);
        }

    }
}
