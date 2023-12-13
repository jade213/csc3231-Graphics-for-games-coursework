using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 5f;
    public float sensitvity = 5f;

    void Update()
    {
        transform.position += transform.forward * Input.GetAxis("Vertical") * speed * Time.deltaTime;
        transform.position += transform.right * Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.eulerAngles += new Vector3(-mouseY * sensitvity, mouseX * sensitvity, 0);
        
    }
}
