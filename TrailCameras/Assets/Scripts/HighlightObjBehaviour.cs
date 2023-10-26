using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HighlightObjBehaviour : MonoBehaviour
{
    public Material highlightMaterial;
  
    private Material originalMaterial;
    public GameObject gameObj;
    public UnityEvent highlightEvent, unhighlightEvent;

    void Start() 
    {
        originalMaterial = GetComponent<Renderer>().material;
        
    }

    public void Highlight() 
    {
        if (gameObj.activeSelf)
        {
            highlightEvent.Invoke();
            GetComponent<Renderer>().material = highlightMaterial;
            StartCoroutine(UnhighlightAfterDelay());
        }
    }
  
    public void Unhighlight() 
    {
        GetComponent<Renderer>().material = originalMaterial; 
        unhighlightEvent.Invoke();
    }
    
    IEnumerator UnhighlightAfterDelay() 
    {
        yield return new WaitForSeconds(8f); 
        Unhighlight();
        unhighlightEvent.Invoke();
    }
}
