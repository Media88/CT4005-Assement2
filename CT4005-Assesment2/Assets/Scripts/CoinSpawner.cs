using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
	[SerializeField]
	public GameObject Coin;

	public int PlaceX;
	public int PlaceZ;
	public int coinCount;

	public void Start()
	{
		coinCount = GameObject.FindGameObjectsWithTag("Coin").Length;
	}

	private void Update()
	{
		if(coinCount < 10)
		{
			Spawn();
			return;
		}
	}

	private void Spawn()
	{
		PlaceX = Random.Range(-7, 18);
		PlaceZ = Random.Range(13,-12);
		Instantiate(Coin,new Vector3 (PlaceX, -0.48f, PlaceZ), transform.rotation);
	}

}
