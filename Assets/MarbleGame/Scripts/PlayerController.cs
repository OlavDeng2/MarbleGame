using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Initialize some variables
    public int lives = 3;
    public float speed = 3f;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
        if (Input.GetButton("left"))
        {
            print("Moving Left");
            //Move left
        }

        if (Input.GetButton("right"))
        {
            print("Moving right");
            //move Right
        }

        if(Input.GetButton("up"))
        {
            print("Moving up");
            //Move Up
        }

        if(Input.GetButton("down"))
        {
            print("Moving down");
            //Move Down
        }
	}
}
