using UnityEngine;
using UnityEngine.InputSystem;

public class CañonMovement : MonoBehaviour
{
    public Transform cañon;
    public float rotationSpeed = 100f;

    private float currentAngleZ = 0f;
    private Vector2 input;
    private Quaternion initialRotation;

    private void Awake()
    {
        initialRotation = cañon.localRotation;
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        input = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        float verticalInput = -input.y;

        currentAngleZ += verticalInput * rotationSpeed * Time.deltaTime;

        cañon.localRotation = initialRotation * Quaternion.Euler(0, 0, currentAngleZ);
    }
}