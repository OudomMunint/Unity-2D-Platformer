using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameWinManager : MonoBehaviour
{
    public void OnTriggerEnter2D()
    {
        //SceneManager.LoadScene("Win Screen");
        SetWinScreen();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Start()
    {
        CurrentLevel();
        AllScenes();
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

}
