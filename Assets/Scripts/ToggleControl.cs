using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class ToggleControl : MonoBehaviour
{
    public Toggle myToggle;
    public void ValueChanged()
    {
        Debug.Log("Value Changed");
    }

    public void ChangeToggle()
    {
        myToggle.isOn = !myToggle.isOn;
    }

}