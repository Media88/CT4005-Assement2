using UnityEngine;
using UnityEngine.UI;

public class ScoreScripts : MonoBehaviour
{
    public GameObject scoreText;
    public int score;

    private void OnTriggerEnter(Collider other)
    {
        score++;
        scoreText.GetComponent<Text>().text = "Score: " + score;
        Destroy(gameObject);
    }

}
