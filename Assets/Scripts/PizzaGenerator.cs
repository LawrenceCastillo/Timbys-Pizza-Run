using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PizzaGenerator : MonoBehaviour {

    public ObjectPooler pizzaPool;

    public float distanceBetweenPizzas;

    public void SpawnPizzas(Vector3 startPosition)
    {
        GameObject pizza1 = pizzaPool.GetPooledObject();
        pizza1.transform.position = startPosition;
        pizza1.SetActive(true);

        GameObject pizza2 = pizzaPool.GetPooledObject();
        pizza2.transform.position = new Vector3(startPosition.x - distanceBetweenPizzas, startPosition.y, startPosition.z);
        pizza2.SetActive(true);

        GameObject pizza3 = pizzaPool.GetPooledObject();
        pizza3.transform.position = new Vector3(startPosition.x + distanceBetweenPizzas, startPosition.y, startPosition.z);
        pizza3.SetActive(true);

    }
}
