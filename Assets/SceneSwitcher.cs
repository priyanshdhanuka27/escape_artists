using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public float endScreenY = -1000f; // The y value threshold for triggering the scene switch
    public string endScreenSceneName = "EndScene"; // The name of the end screen scene

    private bool hasSwitchedScene = false; // Flag to track if scene switch has occurred

    private void Update()
    {
        // Check if the player's y value is less than the threshold and the scene switch has not occurred
        if (transform.position.y < endScreenY && !hasSwitchedScene)
        {
            // Set the scene switch flag to true
            hasSwitchedScene = true;

            // Load the end screen scene
            SceneManager.LoadScene(endScreenSceneName);
        }
    }
}