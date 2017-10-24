using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Initialize some variables
    public int lives = 3;
    public float speed = 3f;

    public bool isMainMenu = true;
    


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MarbleInput(isMainMenu);   
	}

    void MarbleInput(bool isMenu)
    {
        if (isMenu)
        {
            if (Input.GetButton("left"))
            {
                print("Moving Left");
                //Move left
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.left * speed);
            }

            if (Input.GetButton("right"))
            {
                print("Moving right");
                //move Right
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * speed);
            }

            if (Input.GetButton("up"))
            {
                print("Moving up");
                //Move Up
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * speed);
            }

            if (Input.GetButton("down"))
            {
                print("Moving down");
                //Move Down
                gameObject.GetComponent<Rigidbody>().AddForce(Vector3.back * speed);
            }
        }
    }
}
