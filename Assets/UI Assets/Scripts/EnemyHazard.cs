using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHazard : MonoBehaviour
{
    [SerializeField] private float Damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<PlayerHealth>().Healthloose(Damage);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
