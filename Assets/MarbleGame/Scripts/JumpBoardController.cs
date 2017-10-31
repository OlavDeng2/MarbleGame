using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoardController : MonoBehaviour
{
    private void OnMouseDown()
    {
        //Do stuff
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, 5));
        print("Game Object clicked");
    }
}
