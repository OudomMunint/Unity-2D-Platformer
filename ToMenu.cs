using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMenu : MonoBehaviour
{
    /// Goes back to main menu
    public void GoToMain()
    {
        SceneManager.LoadScene("Main Menu");
    }

}
