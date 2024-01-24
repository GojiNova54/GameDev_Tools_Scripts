using System.Globalization;
using UnityEngine;
using UnityEngine.UI;



public class TextLabelBehavior : MonoBehaviour
{
    public Text label;
    public FloatDataSO dataObj;

    public void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();

    }

    public void UpdateLabel () 
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}
