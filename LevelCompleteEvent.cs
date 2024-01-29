using UnityEngine;
using UnityEngine.Events;

public class LevelCompleteEvent : MonoBehaviour
{
    
    public UnityEvent onLevelComplete;

    
    public void InvokeLevelComplete()
    {
        
        onLevelComplete.Invoke();
    }
}

