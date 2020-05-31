using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour
{
   public GameObject scoreTextP1;
   public GameObject scoreTextP2;
   public GameObject scoreTextP3;
   public GameObject scoreTextP4;
   public int scoreP1;
   public int scoreP2;
   public int scoreP3;
   public int scoreP4;

  void OnTriggerEnter(Collider other)
    {
    
       if(other.gameObject.CompareTag ("Player1"))
       {
            scoreP1++;
            scoreTextP1.GetComponent<Text>().text = "Score: " + scoreP1;
            Destroy(gameObject);
	    }
       if(other.gameObject.CompareTag ("Player2"))
       {
            scoreP2++;
            scoreTextP2.GetComponent<Text>().text = "Score: " + scoreP2;
            Destroy(gameObject);
       }
       if(other.gameObject.CompareTag ("Player3"))
       {
            scoreP3++;
            scoreTextP3.GetComponent<Text>().text = "Score: " + scoreP3;
            Destroy(gameObject);
	    }
       if(other.gameObject.CompareTag ("Player4"))
       {
            scoreP4++;
            scoreTextP4.GetComponent<Text>().text = "Score: " + scoreP4;
            Destroy(gameObject);
       }
    }
}
