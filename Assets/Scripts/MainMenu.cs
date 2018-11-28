using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public string playGameScene;
    private AudioSource gameMusic;

    public void PlayGame()
    {
        
        SceneManager.LoadScene(playGameScene);
        gameMusic = GameObject.Find("smb_mariodie").GetComponent<AudioSource>();
        gameMusic.Play();

    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
