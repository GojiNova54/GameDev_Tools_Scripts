
using UnityEngine;

[CreateAssetMenu]
public class InstancerSO : ScriptableObject
{
    public void CreateInstance(GameObject obj)
    {
        Instantiate(obj);
    }
}
