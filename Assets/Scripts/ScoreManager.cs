using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //used to access UI features


public class ScoreManager : MonoBehaviour {

    public Text scoreText;
    public Text hiScoreText;

    public float scoreCount;
    public float hiScoreCount;

    public float pointsPerSecond;

    public bool scoreIncreasing;

	// Use this for initialization
	void Start () {
        bool v = PlayerPrefs.HasKey("HighScore"); // if playerprefs has a value
        if (v)
        {
            hiScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
	}
	
	// Update is called once per frame
	void Update () {
        if(scoreIncreasing)
        {
            scoreCount += pointsPerSecond * Time.deltaTime; // time.delta time is the time since the last frame(it is very small) Ex. 5 * 0.1 = .5points
        }
        

        if(scoreCount > hiScoreCount)
        {
            hiScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hiScoreCount); //saves highscore permanently
        }
        scoreText.text = "Score: " + Mathf.Round(scoreCount); //rounds scorecount to nearest whole number
        hiScoreText.text = "High Score: " + Mathf.Round(hiScoreCount);

	}

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
