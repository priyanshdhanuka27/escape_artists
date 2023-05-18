using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{
    private bool isTeleporting = false;
    private Vector3 teleportPosition;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.H) && Input.GetKey(KeyCode.G) && !isTeleporting)
        {
            isTeleporting = true;
            teleportPosition = new Vector3(-815.4405f, 83.24693f, 1075.995f);
            StartCoroutine(TeleportCoroutine());
        }
    }

    IEnumerator TeleportCoroutine()
    {
        // Disable physics interactions
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;

        // Perform the teleportation
        transform.position = teleportPosition;

        // Wait for a short duration
        yield return new WaitForSeconds(0.1f);

        // Enable physics interactions
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().enabled = true;

        isTeleporting = false;
    }
}