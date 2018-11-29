using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpPoints : MonoBehaviour {

    public int scoreToGive;

    private ScoreManager theScoreManager;

    private AudioSource pizzaSound;

	// Use this for initialization
	void Start () {
        theScoreManager = FindObjectOfType<ScoreManager>();
        pizzaSound = GameObject.Find("Eating").GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Player")
        {
            theScoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);
            if (pizzaSound.isPlaying)
            {
                pizzaSound.Stop();
                pizzaSound.Play();
            }
            else
            {
                pizzaSound.Play();
            }

        }
    }

}
