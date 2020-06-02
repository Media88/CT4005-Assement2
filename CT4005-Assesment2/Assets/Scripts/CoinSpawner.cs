using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	public GameObject Coin;

	public static GameObject instance = null;

	public int PlaceX;
	public int PlaceZ;

	private void Start()
	{
		InvokeRepeating("Update", 2f, 3f);
		return;
	}

	private void Update()
	{
		if(GameObject.FindGameObjectsWithTag("Coin").Length < 10)
		{
			if (Coin != null)
			{
			PlaceX = Random.Range(-7, 18);
			PlaceZ = Random.Range(13,-12);
			Instantiate(Coin,new Vector3 (PlaceX, -0.48f, PlaceZ), transform.rotation);
			return;			
			}
		}
	}
}