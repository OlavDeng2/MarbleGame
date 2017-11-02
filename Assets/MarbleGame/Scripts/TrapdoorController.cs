using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour {

    //force that is supplied to the trapdoor when opened
    public Vector3 force = new Vector3(0, 5000, 0);

    //variable to hold the rigidbody of the trap door
    Rigidbody trapdoorRB = null;

    private void Start()
    {
        //Get the trapdoor rigid body and ensure that it isnt kinematic to stop it from moving before i want to.
        trapdoorRB = gameObject.GetComponent<Rigidbody>();
        trapdoorRB.isKinematic = true;

    }

    private void OnMouseDown()
    {

        //Open the trapdoor!
        trapdoorRB.isKinematic = false;
        trapdoorRB.useGravity = true;
    }
}
