using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatDataSO : ScriptableObject
{
    public float value;
    
    public void SetValue(float num)
    {
        value = num;
    }
    public void UpdateValue(float num)
    {
        value += num;
    }
}
