using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollect : MonoBehaviour
{
    public Text scoreText;
    private int Score;

    public CoinCollect(int _score)
    {
        this.Score = 0;
    }

    public int GetScore()
    { 
        return this.Score;
    }

    public void SetScore(int _score)
    {
        this.Score=_score;
    }



    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        ScoreDisplay();
    }

    void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Coin")
        {
            Score++;
            Destroy(Coin.gameObject);
            ScoreDisplay();
        }
    }

    private void ScoreDisplay()
    {
        scoreText.text = "Score: " + Score;
    }


}
