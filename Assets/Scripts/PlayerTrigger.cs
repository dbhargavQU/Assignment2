using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    public GameOverManager gameOverManager; 

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Trigger detected with: " + other.gameObject.tag);

        if (other.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Trigger with Obstacle detected.");
            gameOverManager.TriggerGameOver();
        }
        else if (other.gameObject.CompareTag("WinObject")) 
        {
            Debug.Log("Trigger with WinObject detected.");
            gameOverManager.TriggerYouWin();
        }
    }
}
