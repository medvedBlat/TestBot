using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;

    private Vector3 startPosition;
    private Quaternion startRotation;

    void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);
    }

    public void ResetPosition()
    {
        transform.position = startPosition;
        transform.rotation = startRotation;
    }

    public Vector3 GetPosition() => transform.position;
    public float GetSpeed() => moveSpeed * Input.GetAxis("Vertical");
    public float GetRotation() => transform.eulerAngles.y;
}