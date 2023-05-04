using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SkipCutscene : MonoBehaviour
{
    // Skips cutscene after level 2
    // Only after level 2 is completed
    public void SkipScene()
    {
        SceneManager.LoadScene("Level 3");
    }

}
