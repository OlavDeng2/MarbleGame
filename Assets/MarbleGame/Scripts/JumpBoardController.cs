using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoardController : MonoBehaviour
{
    //the force to apply to the jumpboard
    public Vector3 force = new Vector3(0, 5000 ,0);

    private void OnMouseDown()
    {
        //TODO Make the jumpboard take better account of direction it is going

        //Get the jumpboard rigidbody and add the force to it to make player jump.
        gameObject.GetComponent<Rigidbody>().AddForce(force);
    }
}
