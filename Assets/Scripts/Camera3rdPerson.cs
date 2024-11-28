using UnityEngine;

public class Camera3rdPerson : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 5.5f;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - target.position;
    }

    void Update()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position,desiredPosition,smoothSpeed);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}
