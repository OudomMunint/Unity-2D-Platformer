using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToAbandon : MonoBehaviour
{
    // Loads out of bound screen
    // Only from lvl 2
    public void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("Abandon Screen");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

