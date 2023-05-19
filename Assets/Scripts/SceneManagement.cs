using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void LoadNextScreen()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextIndex);
    }

    public void LoadPrevScreen()
    {
        int nextIndex = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(nextIndex);
    }

    public void LoadTownScene()
    {
        SceneManager.LoadScene("World");
    }

    public void LoadInfoPage()
    {
        SceneManager.LoadScene("InfoPage");
    }

    public void Exit()
    {
        Application.Quit();
    }
}