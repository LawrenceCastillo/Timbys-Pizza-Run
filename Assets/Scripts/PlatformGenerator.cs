using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator: MonoBehaviour
{

    public GameObject thePlatform; // platform that will be generated
    public Transform generationPoint;
    public float distanceBetween;

    private float platformWidth;

    public float distanceBetweenMin;
    public float distanceBetweenMax;

    //public GameObject[] thePlatforms;
    private int platformSelector;
    private float[] platformWidths;

    public ObjectPooler[] theObjectPools;

    private PizzaGenerator thePizzaGenerator;
    public float randomPizzaThreshold;


    // Use this for initialization
    void Start()
    {
        //platformWidth = thePlatform.GetComponent<BoxCollider2D>().size.x; // gets us length of platform

        platformWidths = new float[theObjectPools.Length];
        for(int i = 0; i < theObjectPools.Length; i++)
        {
            //platformWidths[i] = theObjectPools[i].GetComponent<BoxCollider2D>().size.x;
            platformWidths[i] = theObjectPools[i].pooledObject.GetComponent<BoxCollider2D>().size.x;
        }

        thePizzaGenerator = FindObjectOfType<PizzaGenerator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < generationPoint.position.x)
        {
            distanceBetween = Random.Range(distanceBetweenMin, distanceBetweenMax);

            platformSelector = Random.Range(0, theObjectPools.Length);

            //takes current position and adds platform width of selected platform
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2) + distanceBetween, transform.position.y, transform.position.z);


            //Instantiate(thePlatform, transform.position, transform.rotation); //instantiate creates new object
            //Instantiate(theObjectPools[platformSelector], transform.position, transform.rotation);

            GameObject newPlatform = theObjectPools[platformSelector].GetPooledObject();

            newPlatform.transform.position = transform.position;
            newPlatform.transform.rotation = transform.rotation;
            newPlatform.SetActive(true);

            if (Random.Range(0f, 100f) < randomPizzaThreshold) //if a random num between 0 and 100 is less than our random coin threshold the run code
            {
                thePizzaGenerator.SpawnPizzas(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));
            }
            transform.position = new Vector3(transform.position.x + (platformWidths[platformSelector] / 2), transform.position.y, transform.position.z);

        }
    }
}
