using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    public GameObject coin;
    public bool stopSpawining = false;
    public float spawnTime;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    public void SpawnObject()
    {
        Instantiate(coin, transform.position, transform.rotation);
        if(stopSpawining)
        {
            CancelInvoke("SpawnObject");
		}
	}
}
