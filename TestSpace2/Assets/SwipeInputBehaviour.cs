
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class SwipeInputBehaviour : MonoBehaviour
{
    public InputAction swipeUp;

    void Awake() 
    {
        swipeUp = new InputAction("SwipeUp");
    }
    
    void Start()
    {
        swipeUp.Enable(); 
    }

    void OnDestroy() 
    {
        swipeUp.Disable();
    }
    
    void Update()
    {
        float swipeValue = swipeUp.ReadValue<float>();

        if(swipeValue > 0.8f) 
        {
            Debug.Log("up");
        }
        
        if(swipeUp.phase == InputActionPhase.Started) 
        {
            
        }

        if(swipeUp.phase == InputActionPhase.Canceled) 
        {
            Debug.Log("Ended");
        }
    }
    
}

  