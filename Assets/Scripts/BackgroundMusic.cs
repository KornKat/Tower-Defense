using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    AudioSource backMusic;
    // Start is called before the first frame update
    void Start()
    {
        backMusic = GetComponent<AudioSource>();
        backMusic.Play();
    }
}
