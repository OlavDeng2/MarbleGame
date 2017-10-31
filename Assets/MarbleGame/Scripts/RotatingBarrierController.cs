using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBarrierController : MonoBehaviour {

    public float rotationSpeed = 0f;

    private void FixedUpdate()
    {

    }

    private void OnMouseDown()
    {
        //Do stuff
        gameObject.GetComponent<Transform>().rotate;

        print("Game Object clicked");
    }
}
