using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMenu : MonoBehaviour
{
    public ScoreScripts scoreScripts;
    public GameObject endMenu;

    public int scoreP1;
    public int scoreP2;
    public int scoreP3;
    public int scoreP4;
    public int scoreGoal = 5;
    // Update is called once per frame
    void Update()
    {
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
