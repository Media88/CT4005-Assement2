using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Coin : MonoBehaviour
{
    [SerializeField]
    float CoinRotateSpeed = 0.5f;
    [SerializeField]
    float CoinValue = 1f;

    public ScoreScripts scoreScripts;

    public GameObject endMenu;

    public int scoreP1;
    public int scoreP2;
    public int scoreP3;
    public int scoreP4;
    public int scoreGoal = 5;

    public void Update()
    {
        this.gameObject.transform.Rotate(0, CoinRotateSpeed, 0);
    }

   public void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag ("Player1"))
       {
            scoreScripts.P1Collision();
	    }
       if(other.gameObject.CompareTag ("Player2"))
       {
            scoreScripts.P2Collision();
       }
       if(other.gameObject.CompareTag ("Player3"))
       {
             scoreScripts.P3Collision();           
	   }
       if(other.gameObject.CompareTag ("Player4"))
       {
            scoreScripts.P4Collision();
       }

        if (scoreP1 > scoreGoal)
        {
            endMenu.SetActive(true);
        }
        if (scoreP2 > scoreGoal)
        {
            endMenu.SetActive(true);

        }
        if (scoreP3 > scoreGoal)
        {
            endMenu.SetActive(true);

        }
        if (scoreP4 > scoreGoal)
        {
            endMenu.SetActive(true);

        }
    }
}
