using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terrain : MonoBehaviour
{

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("here");
        if(collision.gameObject.tag == "meteor")
        {
            Destroy(gameObject);
            Debug.Log("destroy if something");
        }
    }
}