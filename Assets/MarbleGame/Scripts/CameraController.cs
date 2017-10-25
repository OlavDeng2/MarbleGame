using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController cameraControll;

    //Variables needed to move the camera around
    Vector3 cameraPosition = new Vector3(0, 0, 0);
    Vector3 playerPosition = new Vector3(0, 0, 0);

    //variable for the distance away from the player
    public Vector3 distanceFromPlayer = new Vector3(0, 0, 0);

    private void Awake()
    {
        if (cameraControll == null)
        {
            DontDestroyOnLoad(gameObject);
            cameraControll = this;
        }
        else if (cameraControll != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        MoveCamera();
    }

    //Move the camera to follow the player
    void MoveCamera()
    {
        //get the position of the player
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        //set the position of the camera to certain distance from the player
        cameraPosition = playerPosition + distanceFromPlayer;
        transform.position = cameraPosition;
    }
}