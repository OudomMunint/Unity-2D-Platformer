using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame : MonoBehaviour
{


    //Variables for the UI ;
    // Loads win screen
    public void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("Win Screen");

    }
    // Update is called once per frame
    void Update()
    {
        
    }

}
