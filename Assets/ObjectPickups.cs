using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickups : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Players do what Players do best.");
            Destroy(gameObject);
        }
    }
}
