using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public void ToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void Restart()
    {
        if (SceneManager.GetActiveScene().name == "Abandon screen")
        {
            SceneManager.LoadScene("Level 2");
        }
    }

    public void RestartL2()
    {
        SceneManager.LoadScene("Level 2");
    }

    public void RestartL3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
    }

    public void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("Abandon screen");
    }

    // Update is called once per frame
    void Update()
    {

    }
}