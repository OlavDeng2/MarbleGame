using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBarrierController : MonoBehaviour {

    //rotation for rotating the object
    public Vector3 rotation = new Vector3(0,0,0);

    //Bool for if the rotating barrier can rotate
    bool canRotate = false;

    private void FixedUpdate()
    {
        //if the object can rotate, rotate the object
        if(canRotate)
        {
            gameObject.GetComponent<Transform>().Rotate(rotation);
        }
    }

    private void OnMouseDown()
    {
        //set the boolean for whether the object can rotate or if it cant
        if(!canRotate){canRotate = true;}
        else if(canRotate) { canRotate = false; }
    }
}
