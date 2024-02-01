using System.Globalization;
using UnityEngine;
using TMPro; 
using UnityEngine.Events;

public class TextLabelBehavior : MonoBehaviour
{
    private TextMeshProUGUI label;
    public UnityEvent startEvent;

    public void Start()
    {
        label = GetComponent<TextMeshProUGUI>(); 
        startEvent.Invoke();
    }

    public void UpdateLabel(FloatDataSO obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateLabel(IntDataSO obj)
    {
        label.text = obj.value.ToString(CultureInfo.InvariantCulture);
    }
}
