using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GOtoMenu : MonoBehaviour
{
    // Goes from gameover screen to main menu
    // On death only
    public void ToMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
