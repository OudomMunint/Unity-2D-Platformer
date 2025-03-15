using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWinManager : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        SetWinScreen();
    }

    private void Start()
    {
        CurrentLevel();
        AllScenes();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public Scene CurrentLevel()
    {
        Scene currentLevel = SceneManager.GetActiveScene();
        return currentLevel;
    }

    public Scene[] AllScenes()
    {
        int sceneCount = SceneManager.sceneCountInBuildSettings;
        Scene[] All = new Scene[sceneCount];
        Debug.Log("Scene Count: " + sceneCount);

        return All;
    }

    public void SetWinScreen()
    {
        switch (CurrentLevel().name)
        {
            case "Level 1":
                SceneManager.LoadScene("Win Screen");
                break;
            case "Level 2":
                SceneManager.LoadScene("Win Screen 2");
                break;
            case "Level 3":
                SceneManager.LoadScene("Win screen 3");
                break;
            default:
                Debug.LogWarning("Unknown level: " + CurrentLevel().name);
                break;
        }
    }

    public void GoToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    // Update is called once per frame
    void Update()
    {

    }
}