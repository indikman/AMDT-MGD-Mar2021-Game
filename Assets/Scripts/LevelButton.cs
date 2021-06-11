using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    public int levelNumber;
    public TextMeshProUGUI levelScoreText;
    public GameObject lockedStatus;


    // Start is called before the first frame update
    void Start()
    {
        lockedStatus.SetActive(false);

        if(PlayerPrefs.GetInt("LevelScore" + levelNumber) > 0)
        {
            levelScoreText.SetText(""+ PlayerPrefs.GetInt("LevelScore" + levelNumber));
        }
        else
        {
            levelScoreText.SetText("");
        }


        if(levelNumber != 1 && PlayerPrefs.GetInt("LevelUnlock" + levelNumber) == 1)
        {
            GetComponent<Button>().interactable = true;
        }
        else if (levelNumber == 1)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            lockedStatus.SetActive(true);
            GetComponent<Button>().interactable = false;
        }

    }

    
}
