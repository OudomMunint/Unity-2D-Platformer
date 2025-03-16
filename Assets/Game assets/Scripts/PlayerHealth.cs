using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float currentHealth { get; private set; }

    [SerializeField]
    private float startHealth;
    private Animator Animation;
    private bool dead;
    public Vector3 PlayerRespawn;
    public LevelManager GameLevelManager;

    void Start()
    {
        PlayerRespawn = transform.position;
        GameLevelManager = FindFirstObjectByType<LevelManager>();
    }

    private void Awake()
    {
        currentHealth = startHealth;
        Animation = GetComponent<Animator>();
    }

    public async Task LoseHealth(float Damage)
    {
        currentHealth = Mathf.Clamp(currentHealth - Damage, 0, startHealth);

        if (currentHealth > 0)
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

                if (SceneManager.GetActiveScene().name == "Level 1")
                {
                    await Task.Delay(2000);
                    GameLevelManager.Respawn();
                    currentHealth = startHealth;
                    dead = false;
                    GetComponent<PlayerControl>().enabled = true;
                }
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