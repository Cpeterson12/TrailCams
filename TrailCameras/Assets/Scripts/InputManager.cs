
using System;
using UnityEngine;
using UnityEngine.InputSystem;

[DefaultExecutionOrder(-1)]
public class InputManager : Singleton<InputManager>
{
  #region Events
  public delegate void StartTouch(Vector2 position, float time);
  public event StartTouch OnStartTouch;
  public delegate void EndTouch(Vector2 position, float time);
  public event EndTouch OnEndTouch;
  #endregion
  
  private TouchControls touchControls;

  public Camera mainCamera;

  public void Update()
  {
   // Debug.Log(touchControls.SwipeInput.PrimaryPosition.ReadValue<Vector2>());
  }

  public void Awake()
  {
    touchControls = new TouchControls();
    mainCamera = Camera.current;
  }

  public void OnEnable()
  {
    touchControls.Enable();
  }

  public void OnDisable()
  {
    touchControls.Disable();
  }

  private void Start()
  {
    touchControls.SwipeInput.PrimaryContact.started += ctx => StartTouchPrimary(ctx);
    touchControls.SwipeInput.PrimaryContact.canceled += ctx => EndTouchPrimary(ctx);
  }

  public void StartTouchPrimary(InputAction.CallbackContext context)
  {
    if (OnStartTouch != null) OnStartTouch(Utils.ScreenToWorld(mainCamera, touchControls.SwipeInput.PrimaryPosition.ReadValue<Vector2>()), (float)context.startTime);
  }
  
  public void EndTouchPrimary(InputAction.CallbackContext context)
  {
    if (OnEndTouch != null) OnStartTouch(Utils.ScreenToWorld(mainCamera, touchControls.SwipeInput.PrimaryPosition.ReadValue<Vector2>()), (float)context.time);
  }

  public Vector2 PrimaryPosition()
  {
    return Utils.ScreenToWorld(mainCamera, touchControls.SwipeInput.PrimaryPosition.ReadValue<Vector2>());
  }
}


