using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
public class MatchBehavior : MonoBehaviour
{
    
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent, noMatchEventDelayedEvent;
    
    private IEnumerator OnTriggerEnter(Collider other)
    {
        var tempObj = other.GetComponent<IDContainerBehavior>();
        if (tempObj == null)
            yield break;
        
        var otherID = tempObj.idObj;
        if (otherID == idObj)
       {
              Debug.Log("Match!");
              matchEvent.Invoke();
       }
       else
       {
                Debug.Log("No Match!");
                noMatchEvent.Invoke();
                yield return new WaitForSeconds(0.5f);
                noMatchEventDelayedEvent.Invoke();
       }
    }
}
