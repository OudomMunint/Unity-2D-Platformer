using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGO2 : MonoBehaviour
{
    // Reloads level 3 from game over screen
    // Only reloads from death screen
    public void RestartLvl3()
    {
        SceneManager.LoadScene("Level 3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
