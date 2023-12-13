using UnityEngine;

public class terrainCollision : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "meteor")
        {
            Destroy(gameObject);
        }
    }
}
