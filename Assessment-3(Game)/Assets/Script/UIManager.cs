using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text highScoreText;
    public Text gameTimeText;

    int newScore = 5000;
    float newGameTime = 150.0f;

    void Start()
    {
        LoadPlayerPrefs();
    }

    void Update()
    {
        int oldHighScore = PlayerPrefs.GetInt("HighScore", 0);
        if (newScore > oldHighScore)
        {
            
            PlayerPrefs.SetInt("HighScore", newScore);
            SavePlayerPrefs(); 
        }

        float oldGameTime = PlayerPrefs.GetFloat("GameTime", 0.0f);
        if (newGameTime > oldGameTime)
        {
            
            PlayerPrefs.SetFloat("GameTime", newGameTime);
            SavePlayerPrefs();
        }
    }

    void LoadPlayerPrefs()
    {
        int loadedHighScore = PlayerPrefs.GetInt("HighScore", 0);
        float loadedGameTime = PlayerPrefs.GetFloat("GameTime", 0.0f);

        highScoreText.text = "High Score: " + loadedHighScore.ToString();
        gameTimeText.text = "Game Time: " + loadedGameTime.ToString("F2");
    }

    void SavePlayerPrefs()
    {
        PlayerPrefs.Save();
    }
}
