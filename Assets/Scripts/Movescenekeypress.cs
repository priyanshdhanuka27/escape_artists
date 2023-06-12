using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movescenekeypress : MonoBehaviour
{
    [SerializeField] private string GameOver;
    [SerializeField] private GameObject uiElement;
    private void OnTriggerStay(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiElement.SetActive(true);

            if(Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene(GameOver);
            }
        }
    }
    
    void OntriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            uiElement.SetActive(false);
        }
    }
}
