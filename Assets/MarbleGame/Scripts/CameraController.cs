using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Variables needed to move the camera around
    Vector3 CameraPosition = new Vector3(0, 0, 0);
    Vector3 PlayerPosition = new Vector3(0, 0, 0);

    //variable for the distance away from the player
    public Vector3 DistanceFromPlayer = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {

        MoveCamera();
    }

    //Move the camera to follow the player
    void MoveCamera()
    {
        //get the position of the player
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform.position;

        //set the position of the camera to certain distance from the player
        CameraPosition = PlayerPosition + DistanceFromPlayer;
        transform.position = CameraPosition;
    }
}