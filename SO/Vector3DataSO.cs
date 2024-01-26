
using UnityEngine;

[CreateAssetMenu]
public class Vector3DataSO : ScriptableObject
{
    public Vector3 Value;
    
    public void SetValue(Vector3 v3)
    {
        Value = v3;
    }

    public void SetValue(Transform t)
    {
        Value= t.position;
    }
    
    public void SetTransform (Transform t)
    {
        t.position = Value;
    }
}

