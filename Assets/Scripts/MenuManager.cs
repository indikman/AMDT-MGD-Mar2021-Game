using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelMenu;

    public AudioSource SFXPlayer;
    public AudioClip popSound;

    private void Start()
    {
        showMainMenu();
    }

    public void showLevelMenu()
    {
        mainMenu.SetActive(false);
        levelMenu.SetActive(true);
    }

    public void showMainMenu()
    {
        mainMenu.SetActive(true);
        levelMenu.SetActive(false);
    }

    public void openLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void playButtonSound()
    {
        SFXPlayer.PlayOneShot(popSound);
    }


}
