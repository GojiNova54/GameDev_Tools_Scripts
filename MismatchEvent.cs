using UnityEngine;
using UnityEngine.Events;

public class MismatchEvent : MonoBehaviour
{
    
    [System.Serializable]
    public class MismatchUnityEvent : UnityEvent<Color, Color>
    {
        
    }

    public MismatchUnityEvent onMismatch;

    
    public void InvokeMismatch(Color color1, Color color2)
    {
        
        onMismatch.Invoke(color1, color2);
    }
}

