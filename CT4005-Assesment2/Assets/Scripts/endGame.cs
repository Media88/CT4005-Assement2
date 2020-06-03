using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{

    [SerializeField]
    private GameObject endScreen;
    [SerializeField]
    private GameObject pauseScreen;

    public ScoreScripts scoreScripts;

    public int scoreP1;
    public int scoreP2;
    public int scoreP3;
    public int scoreP4;
    public int scoreGoal = 5;

    private void Start()
    {
        endScreen.gameObject.SetActive(false);
        pauseScreen.gameObject.SetActive(false);
    }

    void Update()
    {
        if (scoreP1 >= scoreGoal)
        {
             endScreen.gameObject.SetActive(true);
        }
        if (scoreP2 >= scoreGoal)
        {
             endScreen.gameObject.SetActive(true);
        }
        if (scoreP3 >= scoreGoal)
        {
             endScreen.gameObject.SetActive(true);
        }
        if (scoreP4 >= scoreGoal)
        {
             endScreen.gameObject.SetActive(true);
        }
    }
}
