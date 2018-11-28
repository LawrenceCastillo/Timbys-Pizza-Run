using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDestroyer : MonoBehaviour {

    public GameObject bgDestructionPoint;


    // Use this for initialization
    void Start () {

        bgDestructionPoint = GameObject.Find("bgDestructionPoint");

    }

    // Update is called once per frame
    void Update () {
        if (transform.position.x < bgDestructionPoint.transform.position.x)
        {
            // Destroy(gameObject);

            gameObject.SetActive(false);
        }

    }
}
