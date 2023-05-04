using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinGame3 : MonoBehaviour
{


    //Variables for the UI ;
    // Loads win screen2
    public void OnTriggerEnter2D()
    {
        SceneManager.LoadScene("Win screen 3");

    }
    // Update is called once per frame
    void Update()
    {

    }

}
