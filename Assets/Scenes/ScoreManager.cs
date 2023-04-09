using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour
{
    public Text scoreText;

    public ScoreManager(Text _scoreText, int _score)
    {
        score = 0;
        scoreText = _scoreText;
        score = _score;
        UpdateScoreDisplay();
    }

    public void IncreaseScore()
    {
        score++;
        UpdateScoreDisplay();
    }

    private void UpdateScoreDisplay()
    {
        scoreText.text = "Score: " + score;
    }


    private int score;
    
    //encapsulating score 

    public int GetScore()
    {
        return score;
    }

    public void SetScore(int _score)
    {
        this.score = _score;
    }
}
