using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObjects : MonoBehaviour
{
    //Variable for Initial score and coins add on score
    private LevelManager GameLevelManager;
    public int coinValue;

    void Start()
    {
        GameLevelManager = FindObjectOfType<LevelManager>();      
    }


    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);          
        }
      
    }
}
