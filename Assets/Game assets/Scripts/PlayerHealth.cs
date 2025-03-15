using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float startHealth;
    public float currentHealth { get; private set; }
    private Animator Animation;
    private bool dead;

    public Vector3 PlayerRespawn;
    public LevelManager GameLevelManager;

    [System.Obsolete]
    void Start()
    {
        PlayerRespawn = transform.position;
        GameLevelManager = FindObjectOfType<LevelManager>();
    }

    private void Awake()
    {
        currentHealth = startHealth;
        Animation = GetComponent<Animator>();
    }

    public void LoseHealth(float Damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - Damage, 0, startHealth);

        if(currentHealth > 0)
        {
            
            Animation.SetTrigger("Hurt");
           

        }
        else
        {
            if (!dead)
            {
                Animation.SetTrigger("Die");                            
                GetComponent<PlayerControl>().enabled = true;
                dead = true;

                if (SceneManager.GetActiveScene().name == "Level 2")
                {
                    SceneManager.LoadScene("Game Over screen");
                }
                if (SceneManager.GetActiveScene().name == "Level 3")
                {
                    SceneManager.LoadScene("Game Over 2");
                }
            }
        }
    }
}