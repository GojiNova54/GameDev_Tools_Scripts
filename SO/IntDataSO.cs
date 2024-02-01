using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntDataSO : ScriptableObject
{
    public int value;
    
    public UnityEvent disableEvent;

    public void SetValue(int num) 
    {
        value = num;
    }

    public void CompareValue(IntDataSO obj) 
    {
        if (value >= obj.value) 
        {
            
        }
        else 
        {
            value = obj.value;
        }
    }
    public void SetValue(IntDataSO obj) 
    {
        value = obj.value;
    }

    public void UpdateValue (int num) 
    {
        value += num;
    }

   
}
