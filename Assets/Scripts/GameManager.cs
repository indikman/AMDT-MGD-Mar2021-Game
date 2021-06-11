using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameMenuManager menu;

    public AudioSource audioSource;
    public AudioClip coinPickup;

    public int levelNumber;
    public int nextLevel;

    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score is : " + score);
        menu.UpdateScore("" + score);

        audioSource.PlayOneShot(coinPickup);
    }

    public void GameWin()
    {
        PlayerPrefs.SetInt("Level" + levelNumber, 1);
        PlayerPrefs.SetInt("LevelScore" + levelNumber, score);
        PlayerPrefs.SetInt("LevelUnlock"+ nextLevel , 1);
        menu.gameWin();
    }
}
