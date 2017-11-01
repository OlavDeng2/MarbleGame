using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Initialize some variables
    public int lives = 3;
    public float speed = 3f;

    //variable for user movement controll
    public bool canMove = true;

    //The canvas for the UI
    public GameObject UICanvas = null;

    //Spawn Points for other screens
    public GameObject mainMenuSpawn = null;
    public GameObject creditsSpawn = null;
    public GameObject tutorialSpawn = null;

    //Rigidbody
    //Rigidbody rbMarble = null;

    //Bool for if the timer is active
    bool timerActive = false;
    //time spent from start of track
    float timeSinceStart = 0f;

    //Text for the times
    public Text timer = null;

    private void Start()
    {
        EnterMainMenu();
        UICanvas.SetActive(false);
       // rbMarble = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MarbleInput(canMove);

        //Timer to keep track of time spent on the track
        if(timerActive)
        {
            timeSinceStart += Time.deltaTime;
            timer.text = "time: " + Mathf.RoundToInt(timeSinceStart) + " seconds";
        }

	}

    //Handle the input of the marble while in the main menu
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
        MenuSwitch(other);

    }



    //Handles the switching of "scenes" in the main menu
    void MenuSwitch(Collider other)
    {

        //Play the game!
        if (other.tag == "UI" && other.name == "Play")
        {
            PlayGame();
            CameraController.cameraControll.menu = false;
        }

        //Quit the game
        if (other.tag == "UI" && other.name == "QuitButton")
        {
            Application.Quit();

        }

        //Enter the Credits
        if (other.tag == "UI" && other.name == "CreditsButton")
        {
            EnterCredits();
            CameraController.cameraControll.menu = true;
        }

        //Enter the settings
        if (other.tag == "UI" && other.name == "TutorialButton")
        {
            EnterTutorial();
            CameraController.cameraControll.menu = true;
        }

        //Enter the MainMenu
        if (other.tag == "UI" && other.name == "MainMenuButton")
        {
            EnterMainMenu();
            CameraController.cameraControll.menu = true;
        }

        //Finish Line
        if (other.tag == "UI" && other.name == "FinishLine")
        {
            //reset the timer and canvas
            timerActive = false;
            timeSinceStart = 0f;
            UICanvas.SetActive(false);

            //Enter the main menu after finishing the game
            EnterMainMenu();
            CameraController.cameraControll.menu = true;
            canMove = true;
        }
    }

    //Simple functions to change the position to the different "scenes"
    void PlayGame()
    {
        canMove = false;
        UICanvas.SetActive(true);
        timerActive = true;

        // the bellow doesnt work with current interactable objects and how they are set up
        //Freeze the x position of the marble so it does not go off track
        //rbMarble.constraints = RigidbodyConstraints.FreezePositionX;
    }

    void EnterCredits()
    {
        print("you are now in the credits scene");
        gameObject.transform.position = creditsSpawn.transform.position;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    void EnterTutorial()
    {
        print("you are now in the tutorial scene");
        gameObject.transform.position = tutorialSpawn.transform.position;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;

    }

    void EnterMainMenu()
    {
        print("You are now in the main menu scene");
        gameObject.transform.position = mainMenuSpawn.transform.position;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
