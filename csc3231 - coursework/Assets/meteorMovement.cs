using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public Transform target;
    public float rotationSpeed = 1f;
    public float radius = 7.5f; // Adjust as needed

    void Update()
    {
        // Calculate the new position in a circular motion
        float x = target.position.x + Mathf.Cos(rotationSpeed * Time.time) * radius;
        float y = target.position.y+ Mathf.Sin(-rotationSpeed * Time.time) * radius; ;
        float z = target.position.z; // Use -rotationSpeed

        // Set the meteor's position
        transform.position = new Vector3(x, y, z);

        // Make the meteor face the center (target) point
        transform.LookAt(target);
    }
}
