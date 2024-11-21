using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity = 500.0f;
    private float yRotation;

    void LateUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation,-90.0f,90.0f);
        transform.localRotation = Quaternion.Euler(yRotation,0.0f,0.0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
