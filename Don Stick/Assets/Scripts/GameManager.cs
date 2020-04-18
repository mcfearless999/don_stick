using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Player don;
    bool gameHasEnded;
    public void GameOver()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            loadGameOverScreen();
        }
        
    }

    void loadGameOverScreen()
    {
        SceneManager.LoadScene("Game Over Screen");
    }
}
