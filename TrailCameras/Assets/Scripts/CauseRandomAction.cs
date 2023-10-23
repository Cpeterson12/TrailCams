using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CauseRandomAction : MonoBehaviour
{
   
    public UnityEvent[] actions;
    public float minTime;
    public float maxTime;
    public UnityEvent anomalyA1, anomalyA2, anomalyA3, anomalyA4;
    private Coroutine randomizer;
    
    public void BeginGame() 
    {
        actions = new UnityEvent[] 
        {
           anomalyA1, anomalyA2, anomalyA3, anomalyA4
        };
    
        randomizer = StartCoroutine(PerformRandomAction());

    }
    

    IEnumerator PerformRandomAction() 
    {

        int randomIndex = Random.Range(0, actions.Length);
        actions[randomIndex].Invoke();

        float timeToNext = Random.Range(minTime, maxTime);
        yield return new WaitForSeconds(timeToNext);

        StartCoroutine(PerformRandomAction());

    }

    public void OnButtonPressed()
    {
        StopCoroutine(randomizer);
        StartCoroutine(PauseAndResume());
    }

    IEnumerator PauseAndResume()
    {
        yield return new WaitForSeconds(16);
        randomizer = StartCoroutine(PerformRandomAction());
    }

}
