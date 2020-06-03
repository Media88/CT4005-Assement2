using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    [SerializeField]
    float CoinRotateSpeed = 0.5f;

    public GameObject coin;

    public ScoreScripts scoreScripts;

    public void Update()
    {
        this.gameObject.transform.Rotate(0, CoinRotateSpeed, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Player1"))
        {
            scoreScripts.P1Collision();
            Destroy(gameObject);
	    }
        if(other.gameObject.CompareTag ("Player2"))
        {
            scoreScripts.P2Collision();
            Destroy(gameObject);
        }
        if(other.gameObject.CompareTag ("Player3"))
        {
            scoreScripts.P3Collision();       
            Destroy(gameObject);
	    }
        if(other.gameObject.CompareTag ("Player4"))
        {
            scoreScripts.P4Collision();
            Destroy(gameObject);
        }
    }
}
