using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverManager : MonoBehaviour
{
    public GameObject gameOverPanel; // For Game Over UI
    public GameObject youWinPanel;   // For You Win UI

    void Start()
    {
        gameOverPanel.SetActive(false);
        youWinPanel.SetActive(false);
    }

    public void TriggerGameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }

    public void TriggerYouWin()
    {
        Time.timeScale = 0;
        youWinPanel.SetActive(true);
    }
}
