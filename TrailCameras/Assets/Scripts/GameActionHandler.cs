using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
    public GameActionBehaviour gameActionObj;
    public UnityEvent onRaiseEvent;
    private void Start()
    {
        gameActionObj.raise += Raise;
    }

    private void Raise(object obj)
    {
        onRaiseEvent.Invoke();
    }
}
