using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoardController : MonoBehaviour
{
    public Vector3 force = new Vector3(0,0,0);

    private void OnMouseDown()
    {
        //Do stuff
        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 5000, 0));
        print("Game Object clicked");
    }
}
