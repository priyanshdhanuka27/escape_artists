using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    public void LoadNextScreen()
    {
        Debug.Log("button load next screen");
        int nextIndex = SceneManager.GetActiveScene().buildIndex+1;
        SceneManager.LoadScene(nextIndex);
    }
    public void LoadPrevScreen()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex -1;
        SceneManager.LoadScene(nextIndex);
    }
    public void LoadTownScene()
    {
        //int nextIndex = SceneManager.GetActiveScene().buildIndex -1;
        SceneManager.LoadScene("World");
    }
    public void Exit()

    {
        Application.Quit();
    }
    
}
