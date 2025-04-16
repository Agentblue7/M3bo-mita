using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class Coins : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText; 
    private int coinCount = 0; 

    void Start()
    {
        UpdateCoinText();

        Collectable.OnCollected += IncreaseCoinCount;
    }

    private void OnDestroy()
    {

        Collectable.OnCollected -= IncreaseCoinCount;
    }

    private void IncreaseCoinCount()
    {
        coinCount++;
        UpdateCoinText();
    }

    private void UpdateCoinText()
    {
        if (coinText != null)
        {
            coinText.text = $"Coins: {coinCount}";
        }

        if (coinCount >= 15)
        {
            SceneManager.LoadScene("einde");
        }
    }
}