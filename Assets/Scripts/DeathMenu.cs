using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour {

    public string mainMenuLevel;

    private AudioSource mainSound;
    internal bool activeInHierarchy;

   /* void Start()
    {
        mainSound = GameObject.Find("Pizza Rat Score V1").GetComponent<AudioSource>();
        if (mainSound.isPlaying)
        {
            mainSound.Stop();
        }
        else
        {
            mainSound.Play();
        }
    }*/

          
public void RestartGame()
    {
        FindObjectOfType<GameManager>().Reset();      
 
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuLevel);
    }
}
