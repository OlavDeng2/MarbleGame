using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour {
    
    //light variable for hte light component
    Light togglableLight = null;

    private void Start()
    {
        //get the light
        togglableLight = gameObject.GetComponent<Light>();
    }

    //whenever object is pressed
    private void OnMouseDown()
    {
        ToggleLight();
    }


    //Turn on and off the light
    void ToggleLight()
    {
        if (togglableLight.intensity == 0)
        {
            togglableLight.intensity = 1;
        }

        else if (togglableLight.intensity == 1)
        {
            togglableLight.intensity = 0;
        }
    }

}
