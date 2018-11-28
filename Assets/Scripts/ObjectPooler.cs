using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour {

    public GameObject pooledObject;
    public int pooledAmount;

    List<GameObject> pooledObjects; //need to have using System.Collections.Generic to use Lists

    // Use this for initialization
    void Start () {

        pooledObjects = new List<GameObject>();

        for(int i=0; i < pooledAmount; i++)
        {
            GameObject obj = (GameObject) Instantiate(pooledObject); //(GameObject) - casting it as a game object
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
		
	}
    
    public GameObject GetPooledObject()
    {
        for(int i = 0; i < pooledObjects.Count; i++)
        {
            if(!pooledObjects[i].activeInHierarchy)
            {
                return pooledObjects[i];
            }
        }

        GameObject obj = (GameObject)Instantiate(pooledObject); //(GameObject) - casting it as a game object
        obj.SetActive(false);
        pooledObjects.Add(obj);
        return obj;

    }
}
