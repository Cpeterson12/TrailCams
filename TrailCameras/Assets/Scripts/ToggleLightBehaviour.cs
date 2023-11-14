using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLightBehaviour : MonoBehaviour
{
    public bool isLightOn;
    public Light lightToControl;
    
    public void ToggleLight() 
    {
        isLightOn = !isLightOn;
  
        if(isLightOn) {
            lightToControl.enabled = true; 
        }
        else {
            lightToControl.enabled = false;
        }
    }
}
