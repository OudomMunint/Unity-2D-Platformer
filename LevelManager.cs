using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    //Variables for Respawning delay setting
    //Respawning delay mean it will allow the player some times before respawn
    public float PlayerRespawnDelay;
    public PlayerControl PlayerControl;


    //Variable for Collectable item controls
    public int Coins;

    //Variables for the UI 
    public Text ScoreText;
    //public Text Score;

    void Start()
    {
        PlayerControl = FindObjectOfType<PlayerControl>();
        ScoreText.text = "Score: " + Coins;
    }


    void Update()
    {
        
    }

    public void Respawn()
    {
        StartCoroutine("RespawnCoroutine");
    }

    public IEnumerator RespawnCoroutine()
    {
        PlayerControl.gameObject.SetActive(false);
        yield return new WaitForSeconds(PlayerRespawnDelay);
        PlayerControl.transform.position = PlayerControl.PlayerRespawn;
        PlayerControl.gameObject.SetActive(true);
    }

    public void AddCoins(int numberofCoins)
    {
        Coins += numberofCoins;
        ScoreText.text = "Score: " + Coins;
        DontDestroyOnLoad(ScoreText);
    }
}
