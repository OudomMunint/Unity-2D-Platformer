using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public float PlayerRespawnDelay;
    public PlayerControl PlayerControl;
    public int Coins;
    public Text ScoreText;

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

    void Start()
    {
        PlayerControl = FindFirstObjectByType<PlayerControl>();

        if (ScoreText != null)
        {
            ScoreText.text = "Score: " + Coins;
        }
    }

    void Update()
    {
        
    }
}