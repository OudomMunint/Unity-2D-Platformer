using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGO : MonoBehaviour
{
    // Reloads level from game over screen
    // Only reloads from death screen
    public void ReloadFromGO()
    {
        SceneManager.LoadScene("Level 2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
