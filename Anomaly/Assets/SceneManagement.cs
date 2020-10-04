using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneManagement : MonoBehaviour
{
    public Animator transitions;
    AudioManager audio;
    string SceneName;
    private void Start()
    {
        Application.targetFrameRate = 60;
        audio = FindObjectOfType<AudioManager>();
    }

    public void MainMenu()
    {
        audio.ButtonSound();
        SceneName = "Main Menu";
        StartCoroutine(LoadScene());
    }

    public void Game()
    {
        audio.ButtonSound();
        SceneName = "Game";
        StartCoroutine(LoadScene());
    }

    public void GameOver()
    {
        SceneName = "Game Over";
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        transitions.SetTrigger("End");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneName);
    }
}
