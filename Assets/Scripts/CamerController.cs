using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    public PlayerController thePlayer; // store our player

    private Vector3 lastPlayerPosition; // Vector 3 has x,y,z

    private float distanceToMove; 

	// Use this for initialization
	void Start () {

        thePlayer = FindObjectOfType<PlayerController>();
        lastPlayerPosition = thePlayer.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x; // we only care about x position since player is l=moving left

        transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z); // camera wont jump up and down with player

        lastPlayerPosition = thePlayer.transform.position; // takes position of player and stores it into lastPlayerPosition
	}
}
