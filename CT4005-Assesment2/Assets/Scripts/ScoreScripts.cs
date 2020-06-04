using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour
{
    public PauseMenuScripts pauseMenu;

    public GameObject scoreTextP1;
    public GameObject scoreTextP2;
    public GameObject scoreTextP3;
    public GameObject scoreTextP4;
    public GameObject endMenu;

    [SerializeField]
    private GameObject playerWinText;
    
    public int scoreP1;
    public int scoreP2;
    public int scoreP3;
    public int scoreP4;

    public int scoreGoal = 5;


    public void P1Collision()
	{
		scoreP1++;
        scoreTextP1.GetComponent<Text>().text = "Score: " + scoreP1;
        if (scoreP1 > scoreGoal)
        {
            pauseMenu.EndGame();
            playerWinText.GetComponent<Text>().text = "Player 1 Wins!";
        }
    }

	public void P2Collision()
	{
        scoreP2++;
        scoreTextP2.GetComponent<Text>().text = "Score: " + scoreP2;
        if (scoreP2 > scoreGoal)
        {
            pauseMenu.EndGame();
            playerWinText.GetComponent<Text>().text = "Player 2 Wins!";
        }
    }

	public void P3Collision()
	{
		scoreP3++;
        scoreTextP3.GetComponent<Text>().text = "Score: " + scoreP3;
        if (scoreP3 > scoreGoal)
        {
            pauseMenu.EndGame();
            playerWinText.GetComponent<Text>().text = "Player 3 Wins!";
        }
    }

	public void P4Collision()
	{
        scoreP4++;
        scoreTextP4.GetComponent<Text>().text = "Score: " + scoreP4;
        if (scoreP4 > scoreGoal)
        {
            pauseMenu.EndGame();
            playerWinText.GetComponent<Text>().text = "Player 4 Wins!";
        }
    }

}
