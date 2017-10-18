using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Initialize some variables
    public int lives = 3;
    public float speed = 3f;



	// Use this for initialization
	void Start ()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("left"))
        {
            //Move left
        }

        if (Input.GetButton("right"))
        {
            //move Right
        }

        if(Input.GetButton("up"))
        {
            //Move Up
        }

        if(Input.GetButton("down"))
        {
            //Move Down
        }
	}
}
