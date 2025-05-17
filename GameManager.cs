using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public int keysCollected = 0;
    public int totalKeys = 3;
    public int playerHealth = 3;

    public TextMeshProUGUI keyText;
    public TextMeshProUGUI healthText;
    public GameObject winPanel;
    public GameObject losePanel;

    void Awake()
    {
        if (Instance == null)
            Instance = this;
            //Destroy(gameObject);
    }

    public void CollectKey()
    {
        keysCollected++;
        keyText.text = "Keys: " + keysCollected;
    }

    public void TakeDamage(int damage)
    {
        playerHealth -= damage;
        healthText.text = "HP: " + playerHealth;

        if (playerHealth <= 0)
        {
            losePanel.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    public void WinGame()
    {
        winPanel.SetActive(true);
        Time.timeScale = 0f;
    }
}
