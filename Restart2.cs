using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart2 : MonoBehaviour
{
    // Reloads level 2
    // Only reloads level that has just finish
    public void Reload2()
    {
        SceneManager.LoadScene("Level 2");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
