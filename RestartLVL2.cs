using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLVL2 : MonoBehaviour
{
    // Reloads level 2 from out of bounds screen
    // Only reloads from lvl 2
    public void ReloadLvl2()
    {
        SceneManager.LoadScene("Level 2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}