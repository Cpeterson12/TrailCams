using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu]
public class GameActionBehaviour : ScriptableObject
{
    public UnityAction<object> raise;
    public UnityAction raiseNoArgs;

    public void RaiseAction(object obj)
    {
        raise?.Invoke(obj);
    }

    public void RaiseAction()
    {
        raiseNoArgs?.Invoke();
    }
    
    public void RaiseAction(float obj)
    {
        raise?.Invoke(obj);
    }
    
    public void RaiseAction(int obj)
    {
        raise?.Invoke(obj);
    }

    public void RaiseAction(Transform obj)
    {
        raise?.Invoke(obj);
    }
    
    public void RaiseAction(GameObject obj)
    {
        raise?.Invoke(obj);
    }
}