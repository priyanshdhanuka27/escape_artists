using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class AutoLoadNextScene : MonoBehaviour
{
    [SerializeField] float delay = 10f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LoadNextSceneAfterDelay());
    }

    IEnumerator LoadNextSceneAfterDelay()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}