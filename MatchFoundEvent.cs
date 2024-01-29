using UnityEngine;
using UnityEngine.Events;

public class MatchFoundEvent : MonoBehaviour
{
    
    [System.Serializable]
    public class MatchFoundUnityEvent : UnityEvent<Color>
    {
        
    }

    public MatchFoundUnityEvent onMatchFound;

   
    public void InvokeMatchFound(Color matchedColor)
    {
        
        onMatchFound.Invoke(matchedColor);
    }
}