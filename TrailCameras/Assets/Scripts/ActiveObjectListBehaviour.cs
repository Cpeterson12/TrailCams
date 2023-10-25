using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActiveObjectListBehaviour : MonoBehaviour 
{

    public GameObject[] objectsToTrack;
    
    public UnityEvent OnManyObjectsActive;
    
    private List<GameObject> activeObjects = new List<GameObject>();

    void Update()
    {
        foreach(GameObject obj in objectsToTrack) 
        {
            if (obj.activeInHierarchy && !activeObjects.Contains(obj)) 
            {
                activeObjects.Add(obj);
            } else if (!obj.activeInHierarchy && activeObjects.Contains(obj)) 
            {
                activeObjects.Remove(obj);
            }
        }
        
        if (activeObjects.Count > 4 && OnManyObjectsActive != null) 
        {
            OnManyObjectsActive.Invoke(); 
        }

    }
}
