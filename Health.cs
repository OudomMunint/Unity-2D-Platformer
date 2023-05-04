using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    //PlayerHealth PlayerHealth = new PlayerHealth();
    [SerializeField] private PlayerHealth PlayerHealth;
    [SerializeField] private Image TotalHealthbar;
    [SerializeField] private Image CurrentHealthbar;


    private void Start()
    {
        TotalHealthbar.fillAmount = PlayerHealth.currentHealth / 10;
    }

    private void Update()
    {
        CurrentHealthbar.fillAmount = PlayerHealth.currentHealth / 10;
    }
}
