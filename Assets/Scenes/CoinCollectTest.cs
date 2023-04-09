using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectTest : MonoBehaviour
{
    public ScoreManager scoreManager;

    void OnTriggerEnter2D(Collider2D Coin)
    {
        if (Coin.tag == "Coin")
        {
            scoreManager.IncreaseScore();
            Destroy(Coin.gameObject);
        }
    }
}
