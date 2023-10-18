using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightObjBehaviour : MonoBehaviour
{
    public Material highlightMaterial;
  
    private Material originalMaterial;
    public GameObject gameObj;

    void Start() 
    {
        originalMaterial = GetComponent<Renderer>().material;
        
    }

    public void Highlight() 
    {
        if (gameObj.activeSelf)
        {
            GetComponent<Renderer>().material = highlightMaterial;
            StartCoroutine(UnhighlightAfterDelay());
        }
    }
  
    public void Unhighlight() 
    {
        GetComponent<Renderer>().material = originalMaterial; 
    }
    
    IEnumerator UnhighlightAfterDelay() 
    {
        yield return new WaitForSeconds(8f); 
        Unhighlight();
    }
}
