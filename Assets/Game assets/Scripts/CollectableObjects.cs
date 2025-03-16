using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableObjects : MonoBehaviour
{
    //Init scrore values
    private LevelManager GameLevelManager;
    public int coinValue;

    void Start()
    {
        GameLevelManager = FindFirstObjectByType<LevelManager>();      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameLevelManager.AddCoins(coinValue);
            Destroy(gameObject);          
        } 
    }

    void Update()
    {

    }
}