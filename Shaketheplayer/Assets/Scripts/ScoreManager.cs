using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int highScore;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI highscoreDisplay;
    public TextMeshProUGUI gameoverScoreDisplay;


    private void Start()
    {
        scoreDisplay.text = "0";
       
        highscoreDisplay.text = PlayerPrefs.GetInt("Highscore",0).ToString();
    }
    private void Update()
    {
        NewScore();
    }

    private void LateUpdate()
    {
        gameoverScoreDisplay.text = "Score : " + score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstacle"))
        {
            score++;
            Debug.Log(score);
        }
    }

    void NewScore()
    {
        scoreDisplay.text = score.ToString();
        if (score>PlayerPrefs.GetInt("Highscore",0))
        {
             PlayerPrefs.SetInt("Highscore", score); 
            highscoreDisplay.text = score.ToString();
        }



    }
}
