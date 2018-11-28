using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGenerator : MonoBehaviour {

    public GameObject bg;
    public Transform bgGenerationPoint;
    public float distanceBetween;

    private float bgWidth;

	// Use this for initialization
	void Start () {
        bgWidth = bg.GetComponent<BoxCollider2D>().size.x; 
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.position.x < bgGenerationPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x + bgWidth + distanceBetween, transform.position.y, transform.position.z);
            Instantiate(bg, transform.position, transform.rotation);
        }
	}
}
