using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour {

    public Vector3 force = new Vector3(0, 5000, 0);

    Rigidbody trapdoorRB;

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

        print("Game Object clicked");
    }
}
