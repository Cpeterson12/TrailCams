using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickTimerBehaviour : MonoBehaviour
{

    public UnityEvent timerEnd;

    void OnMouseDown() 
    {
        StartCoroutine(DisableAfterTime());
    }

    IEnumerator DisableAfterTime() 
    {
        float randomTime = Random.Range(1.0f, 3.0f);
        yield return new WaitForSeconds(randomTime);
        timerEnd.Invoke();
    }
}
