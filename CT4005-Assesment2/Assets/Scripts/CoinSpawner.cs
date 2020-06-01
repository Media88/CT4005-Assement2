using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	[SerializeField]
	public GameObject Coin;

	public int PlaceX;
	public int PlaceZ;


	private void Update()
	{
		if(GameObject.FindGameObjectsWithTag("Coin").Length < 10)
		{
			Spawn();
		}
	}

	private void Spawn()
	{
		PlaceX = Random.Range(-7, 18);
		PlaceZ = Random.Range(13,-12);
		Instantiate(Coin,new Vector3 (PlaceX, -0.48f, PlaceZ), transform.rotation);
	}

}
