using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public Transform cameraTransform;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        // Flatten the direction vectors to keep movement horizontal
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 movement = (forward * vertical + right * horizontal).normalized;

        transform.Translate(movement * speed * Time.deltaTime, Space.World);
    }
}
