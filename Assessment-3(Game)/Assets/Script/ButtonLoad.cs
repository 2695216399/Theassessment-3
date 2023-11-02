using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEditor;
using UnityEngine.Events;

public class ButtonLoad : MonoBehaviour
{

    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadFirstLevel()
    {
        string currentSceneName = SceneManager.GetActiveScene().name;

        SceneManager.LoadScene("PacScene");


        DontDestroyOnLoad(gameObject);
    }

    public void QuitGame()
    {
        Debug.Log("Quit button clicked");
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
    Application.Quit();
#endif
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "WalkingScene")
        {
            GameObject quitButton = GameObject.FindWithTag("QuitButton");

            if (quitButton != null)
            {
                Button buttonComponent = quitButton.GetComponent<Button>();

                buttonComponent.onClick.AddListener(QuitGame);
            }
        }
    }

}
