using UnityEngine;

public class daynightcycle : MonoBehaviour
{
    
    public float dayLengthMinutes = 0.5f;
    
    private float rotationSpeed = 20f;

    void Start()
    {
        rotationSpeed = 360 / dayLengthMinutes / 60;
    }

    void Update()
    {
        transform.Rotate(new Vector3(1, 0, 0) * rotationSpeed * Time.deltaTime);
    }
}
