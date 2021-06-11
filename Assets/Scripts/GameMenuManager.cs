using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMenuManager : MonoBehaviour
{
    public GameObject exitPanel;
    public GameObject winPanel;

    public TextMeshProUGUI scoreText;

    private void Start()
    {
        exitPanel.SetActive(false);
        winPanel.SetActive(false);
    }


    public void showExitPanel()
    {
        //PAUSE THE GAME
        Time.timeScale = 0;

        exitPanel.SetActive(true);
    }

    public void resumeGame()
    {
        exitPanel.SetActive(false);
        //RESUME THE GAME
        Time.timeScale = 1;

    }

    public void exitGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync("Menu");
    }

    public void gameWin()
    {
        Time.timeScale = 0;

        winPanel.SetActive(true);
    }


    public void UpdateScore(string score)
    {
        scoreText.SetText(score);
    }
    
}
