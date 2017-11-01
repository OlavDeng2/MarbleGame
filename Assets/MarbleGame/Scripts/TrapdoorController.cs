using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorController : MonoBehaviour {
    public Vector3 force = new Vector3(0, 5000, 0);

    private void OnMouseDown()
    {
        //Launch the jumpboard!
        gameObject.GetComponent<Rigidbody>().AddForce(force);

        print("Game Object clicked");
    }
}
