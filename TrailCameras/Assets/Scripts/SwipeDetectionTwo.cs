
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class SwipeDetectionTwo : MonoBehaviour
{
   public static SwipeDetectionTwo instance;
   
   public delegate void Swipe(Vector2 direction);

   //public event Swipe swipePerformed;

   public UnityEvent YswipePerformedEvent, XswipePerformedEvent ;

   [SerializeField] private InputAction position, press;

   [SerializeField] private float swipeResistance = 20f;

   private Vector2 initialPos;
   
   private Vector2 currentPos => position.ReadValue<Vector2>();
   private void Awake()
   {
      position.Enable();
      press.Enable();
      press.performed += _ => { initialPos = currentPos; };
      press.canceled += _ => DetectSwipe();
      instance = this;
      
   }

   private void DetectSwipe()
   {
      Vector2 delta = currentPos - initialPos;
      Vector2 direction = Vector2.zero;
      
      if (Mathf.Abs(delta.x) > swipeResistance)
      {
         direction.x = Mathf.Clamp(delta.x, -1, 1);
         XswipePerformedEvent.Invoke();
      }
      if (Mathf.Abs(delta.y) > swipeResistance)
      {
         direction.y = Mathf.Clamp(delta.y, -1, 1);
         YswipePerformedEvent.Invoke();
         
      }

    //  if (direction != Vector2.zero & swipePerformed != null)
      {
        // swipePerformed(direction);
        // Debug.Log("working");
      }
   }
   
}

