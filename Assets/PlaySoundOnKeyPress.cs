using UnityEngine;

public class PlaySoundOnKeyPress : MonoBehaviour
{
    public AudioClip buttonSound;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = buttonSound;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.H)) // Check if both 'G' and 'H' are pressed
        {
            audioSource.Play();
        }
    }
}