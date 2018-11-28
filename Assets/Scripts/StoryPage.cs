using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryPage : MonoBehaviour {

    public string gameScene;
   // private AudioSource gameMusic;

    public void PlayGame()
    {

        SceneManager.LoadScene(gameScene);
      //  gameMusic = GameObject.Find("smb_mariodie").GetComponent<AudioSource>();
      //  gameMusic.Play();

    }

}
