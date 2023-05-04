using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Continue : MonoBehaviour
{
    // Continues from level 1 to 2
     public void ContinueLvl2()
    {
        SceneManager.LoadScene("Level 2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
