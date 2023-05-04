using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerController : MonoBehaviour {

    //Scripts Written by US
    public GameObject FollowPlayer;
    public float CameraPosition;
    public float SmoothCameraPosition;
    private Vector3 PlayerPosition;


//----------------------------------------------------------
    //Default scripts with the scene
    //Unused
    //public float speed;
    //public float clampLeft;
    //public float clampRight;

    //private float cameraX;
//----------------------------------------------------------

    void Start ()
    {   //Not in use  
        //cameraX = transform.position.x;
    }
	
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

        //Using lerp to moving the camera smoothly
        transform.position = Vector3.Lerp(transform.position, PlayerPosition, SmoothCameraPosition * Time.deltaTime);



//-------------------------------------------------------------------------------------
        //Default Script
        //Not in use

        //if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < clampRight)
        //{
        //    transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > clampLeft)
        //{
        //    transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        //}
        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log(cameraX);
        //}
//---------------------------------------------------------------------------------------
    }
}
