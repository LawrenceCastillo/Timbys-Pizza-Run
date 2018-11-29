using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerController thePlayer;
    private Vector3 playerStartPoint;

    private PlatformDestroyer[] platformList;

    private ScoreManager theScoreManager;

    public DeathMenu theDeathScreen;

    private AudioSource themeSong;


	// Use this for initialization
	void Start () {
        platformStartPoint = platformGenerator.position;
        playerStartPoint = thePlayer.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
        themeSong = GameObject.Find("Pizza Rat Score V1").GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RestartGame()
    {
        //StartCoroutine("RestartGameCo");

        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false); // hides player after they die
        theDeathScreen.gameObject.SetActive(true);
        themeSong.Stop();
    }

    public void Reset()
    {
        theDeathScreen.gameObject.SetActive(false);
        themeSong.Play();



        platformList = FindObjectsOfType<PlatformDestroyer>(); //searches for all platforms of type destructor
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false); // platforms which are in the game when the player dies, all disappear
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true); // makes the player visible again

        theScoreManager.scoreCount = 0; //resets score count to 0 after death
        theScoreManager.scoreIncreasing = true; //sets score increasing to true
    }

   /* public IEnumerator RestartGameCo()
    {
        theScoreManager.scoreIncreasing = false;
        thePlayer.gameObject.SetActive(false); // hides player after they die
        yield return new WaitForSeconds(0.5f); // this creates a delay before resetting the player
        platformList = FindObjectsOfType<PlatformDestroyer>(); //searches for all platforms of type destructor
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false); // platforms which are in the game when the player dies, all disappear
        }

        thePlayer.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        thePlayer.gameObject.SetActive(true); // makes the player visible again

        theScoreManager.scoreCount = 0; //resets score count to 0 after death
        theScoreManager.scoreIncreasing = true; //sets score increasing to true
    

    }*/
}
