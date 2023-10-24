using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraSwitchBehaviour : MonoBehaviour
{

    public UnityEvent CameraSwitch;

    public Camera camera1;
    public Camera camera2; 
    public Camera camera3;
  
    private int currentCamera = 0;

    public void UpdateCamera() 
    {
        currentCamera++;
        if(currentCamera > 2)
        {
            currentCamera = 0;  
        }
      
        switchCamera();
        
    }
  
    void switchCamera() {
        camera1.gameObject.SetActive(currentCamera == 0);
        camera2.gameObject.SetActive(currentCamera == 1); 
        camera3.gameObject.SetActive(currentCamera == 2);
    }

}

