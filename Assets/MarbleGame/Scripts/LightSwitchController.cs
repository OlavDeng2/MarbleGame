using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour {

    private void OnMouseDown()
    {
        ToggleLight();
    }


    //Turn on and off the light
    void ToggleLight()
    {
        if (gameObject.GetComponent<Light>().intensity == 0)
        {
            gameObject.GetComponent<Light>().intensity = 1;
        }
        else if (gameObject.GetComponent<Light>().intensity == 1)
        {
            gameObject.GetComponent<Light>().intensity = 0;
        }
    }

}
