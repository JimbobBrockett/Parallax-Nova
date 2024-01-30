using UnityEngine;

public class BackgroundImageScript : MonoBehaviour
{
    [SerializeField] private float fixedRotationY = -90f;
    [SerializeField] private float fixedRotationZ = 90f;
    [SerializeField] private float rotationSpeed = 10f;

    void Update()
    {
        // Get the current rotation
        Vector3 currentRotation = transform.eulerAngles;

        // Apply the fixed rotations for Y and Z axes
        currentRotation.y = fixedRotationY;
        currentRotation.z = fixedRotationZ;

        // Calculate rotation around the x-axis based on time and speed for a full circle
        float rotationX = Mathf.Repeat(Time.time * rotationSpeed, 360f);
        currentRotation.x = rotationX;

        // Update the object's rotation
        transform.eulerAngles = currentRotation;
    }
}
