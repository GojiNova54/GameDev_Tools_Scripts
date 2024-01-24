
using UnityEngine;

[CreateAssetMenu]
public class BoolDataSO : ScriptableObject
{
    public bool boolValue;

    public void UseBoolData()
    {
       
        bool isActivated = boolValue;

        
        if (isActivated)
        {
            Debug.Log("The feature is activated!");
        }
        else
        {
            Debug.Log("The feature is deactivated.");
        }
    }

    
}


