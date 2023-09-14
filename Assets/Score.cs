using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Score : MonoBehaviour
{
    public static Score instance;

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI MaxScoreText;

    private int score;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        scoreText.text = score.ToString();

        MaxScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }


     private void UpdateMaxScore()
    {
        if(score > PlayerPrefs.GetInt("higScore"))
        {
            PlayerPrefs.SetInt("HighScore", score);
            MaxScoreText.text = score.ToString();
        }
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = score.ToString();
        UpdateMaxScore();
    }
}
