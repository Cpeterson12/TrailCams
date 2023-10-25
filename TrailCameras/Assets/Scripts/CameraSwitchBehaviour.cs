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

    void Start()
    {
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
    }

    void UpdateCamera() 
    {

        currentCamera++;
        if(currentCamera > 2) {
            currentCamera = 0;  
        }

        switchCamera();

    }

    void switchCamera()
    {
        
        camera1.gameObject.SetActive(false);
        camera2.gameObject.SetActive(false);
        camera3.gameObject.SetActive(false);
        
        if(currentCamera == 0) {
            camera1.gameObject.SetActive(true);
        }
        else if(currentCamera == 1) {
            camera2.gameObject.SetActive(true);
        }
        else if(currentCamera == 2) {
            camera3.gameObject.SetActive(true);
        }

    }

}

