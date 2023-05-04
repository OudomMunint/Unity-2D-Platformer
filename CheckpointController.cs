using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    public Sprite CkPoint;
    public Sprite CkPointChange;
    private SpriteRenderer CheckpointSpriteRenderer;
    public bool ReachCheckpoint;
    
    void Start()
    {
        CheckpointSpriteRenderer = GetComponent<SpriteRenderer>();
    }

   
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            CheckpointSpriteRenderer.sprite = CkPointChange;
            ReachCheckpoint = true;
        }
    }
}
