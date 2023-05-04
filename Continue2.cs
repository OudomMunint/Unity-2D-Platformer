using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Continue2 : MonoBehaviour
{
    // Continues from level 2 to 3
    public void ContinueLvl3()
    {
        SceneManager.LoadScene("Level 3");
    }

    // Update is called once per frame
    void Update()
    {

    }
}