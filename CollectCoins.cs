using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEditor.SceneManagement;

public class collectCoins : MonoBehaviour
{

    private int coins = 0;

    [SerializeField] private Text coinsText;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTage("Coin"))
        {
            Destroy(collision.gameObject);
            coins++;
            coinsText.text = "Coins: " + coins;
        }
    }
}
    
