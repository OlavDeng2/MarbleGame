using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    //Initialize some variables
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
    Rigidbody marbleRB = null;

    //Bool for if the timer is active
    bool timerActive = false;
    //time spent from start of track
    float timeSinceStart = 0f;

    //Text for the times
    public Text timer = null;

    private void Start()
    {
        //get the marble rigid body
        marbleRB = gameObject.GetComponent<Rigidbody>();

        //make sure to start in the main menu and all variables are set correctly
        EnterMainMenu();

        //Canvas is not needed in the main menu
        UICanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if the marble can move, handle the input
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
        //Handle the Main Menu Interaction
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
            //Enter the main menu after finishing the game
            EnterMainMenu();
        }
    }

    //Simple functions to change the position to the different "scenes"
    void PlayGame()
    {
        canMove = false;
        UICanvas.SetActive(true);
        timerActive = true;

        //Freeze the x position of the marble so it does not go off track
        marbleRB.constraints = RigidbodyConstraints.FreezePositionX;
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

    public void EnterMainMenu()
    {
        //reset everything
        timeSinceStart = 0f;
        print("You are now in the main menu scene");
        canMove = true;
        timerActive = false;
        UICanvas.SetActive(false);
        CameraController.cameraControll.menu = true;
        marbleRB.constraints = RigidbodyConstraints.None;

        //set the marbles position to the main menu spawn
        gameObject.transform.position = mainMenuSpawn.transform.position;
        gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }
}
