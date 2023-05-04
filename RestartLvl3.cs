using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLvl3 : MonoBehaviour
{
    // Reloads level 3 from out of bounds screen
    // Only reloads from lvl 3
    public void ReloadLvl3()
    {
        SceneManager.LoadScene("Level 3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}