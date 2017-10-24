using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    //Initialize some variables
    public int lives = 3;
    public float speed = 3f;

    public bool canMove = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        MarbleInput(canMove);   
	}

    void MarbleInput(bool move)
    {
        if (move)
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

    private void OnTriggerEnter(Collider other)
    {
        print("object hit" + other);

        //Play the game!
        if(other.tag == "UI" && other.name == "Play")
        {
            PlayGame();
        }

        //Quit the game
        if (other.tag == "UI" && other.name == "Quit")
        {
            Application.Quit();
        }

        //Enter the Credits
        if (other.tag == "UI" && other.name == "Credits")
        {
            EnterCredits();
        }

        //Enter the settings
        if (other.tag == "UI" && other.name == "Tutorial")
        {
            EnterTutorial();
        }

    }

    //Start the game
    void PlayGame()
    {
        canMove = false;
    }

    void EnterCredits()
    {
        print("you are now in the credits scene");
    }

    void EnterTutorial()
    {
        print("you are now in the tutorial scene");
    }

    void EnterMainMenu()
    {
        print("You are now in the main menu scene");
    }
}
