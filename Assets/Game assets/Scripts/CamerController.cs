using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour
{
    public GameObject FollowPlayer;
    public float CameraPosition;
    public float SmoothCameraPosition;
    private Vector3 PlayerPosition;

	void Update ()
    {
        PlayerPosition = new Vector3 (FollowPlayer.transform.position.x, transform.position.y, transform.position.z );

        if(FollowPlayer.transform.localScale.x > 0f)
        {
            PlayerPosition = new Vector3(PlayerPosition.x + CameraPosition, PlayerPosition.y, PlayerPosition.z);
        }
        else
        {
            PlayerPosition = new Vector3(PlayerPosition.x - CameraPosition, PlayerPosition.y, PlayerPosition.z);
        }

        // Camera smoothing via Lerp
        transform.position = Vector3.Lerp(transform.position, PlayerPosition, SmoothCameraPosition * Time.deltaTime);

        // Log FPS
        // Debug.Log(1 / Time.deltaTime);
    }

    void Start()
    {

    }
}