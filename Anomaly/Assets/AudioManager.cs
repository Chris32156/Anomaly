using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioClip Button;
    [SerializeField] AudioClip Correct;
    [SerializeField] AudioClip Wrong;
    [SerializeField] AudioClip GameOver;
    AudioSource audio;

    private void Awake()
    {
        var objs = FindObjectsOfType<AudioManager>();

        if (objs.Length > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void ButtonSound()
    {
        audio.PlayOneShot(Button);
    }

    public void CorrectSound()
    {
        audio.PlayOneShot(Correct);
    }

    public void WrongSound()
    {
        audio.PlayOneShot(Wrong);
    }

    public void GameOverSound()
    {
        audio.PlayOneShot(GameOver);
    }
}
