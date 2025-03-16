using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    // Walking
    public float PlayerSpeed = 5f;
    public float PlayerMovement = 0f;

    // Junping
    public float PlayerJumpSpeed = 4f;
    public Transform JumpGroundCheck;
    public float JumpGround;
    public LayerMask GroundLayer;
    private bool IsTouchingGround;

    //Player Animation
    private Animator PlayerAnimation;

    //Player Checkpoint and Respawn
    public Vector3 PlayerRespawn;
    public LevelManager GameLevelManager;

    //Defining Rigidbody
    Rigidbody2D PlayerRigid;

    void Start()
    {
        PlayerRigid = GetComponent<Rigidbody2D>();
        PlayerAnimation = GetComponent<Animator>();
        GameLevelManager = FindFirstObjectByType<LevelManager>();
        PlayerRespawn = transform.position;
    }

    void Update()
    {
        PlayerWalk();         
        PlayerJump();         
        PlayerAnimationWork();
    }

    public void PlayerWalk()
    {
        PlayerMovement = Input.GetAxis("Horizontal");

        if (PlayerMovement > 0f || PlayerMovement < 0f)
        {
            PlayerRigid.velocity = new Vector2(PlayerMovement * PlayerSpeed, PlayerRigid.velocity.y);
             
            // Face player to walking direction
            if (PlayerMovement > 0f)
            {
                transform.localScale = new Vector2(1f, 1f);
            }
            else if (PlayerMovement < 0f)
            {
                transform.localScale = new Vector2(-1f, 1f);
            }
        }
        else
        {
            PlayerRigid.velocity = new Vector2(0, PlayerRigid.velocity.y);
        }
    }

    public void PlayerJump()
    {
        IsTouchingGround = Physics2D.OverlapCircle(JumpGroundCheck.position, JumpGround, GroundLayer);

        if (Input.GetButtonDown("Jump") && IsTouchingGround)
        {
            PlayerRigid.velocity = new Vector2(PlayerRigid.velocity.x, PlayerJumpSpeed);
        }
    }

    public void PlayerAnimationWork()
    {
        PlayerAnimation.SetFloat("Speed", Mathf.Abs(PlayerRigid.velocity.x));
        PlayerAnimation.SetBool("OnGround", IsTouchingGround);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "FallDetector") 
        {
            GameLevelManager.Respawn();
        }
        if (other.tag == "Checkpoint")
        {
            PlayerRespawn = other.transform.position;
        }
    }
}