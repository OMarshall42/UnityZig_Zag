using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;

    private int score = 0;


    public void UpdateScore()
    {
        score += 1;
        scoreText.text = "Score: " + score;
    }

    public void EndGame()
    {
        FindObjectOfType<EndGameUI>().ShowScores(score);
    }
    public void UpdateScoreTwo()
    {
        score += 5;
        scoreText.text = "Score: " + score;

    }

}
