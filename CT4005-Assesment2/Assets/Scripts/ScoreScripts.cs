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


	public void P1Collision()
	{
		scoreP1++;
        scoreTextP1.GetComponent<Text>().text = "Score: " + scoreP1;
	}

	public void P2Collision()
	{
        scoreP2++;
        scoreTextP2.GetComponent<Text>().text = "Score: " + scoreP2;
	}

	public void P3Collision()
	{
		scoreP3++;
        scoreTextP3.GetComponent<Text>().text = "Score: " + scoreP3;
	}

	public void P4Collision()
	{
        scoreP4++;
        scoreTextP4.GetComponent<Text>().text = "Score: " + scoreP4;
	}

}
