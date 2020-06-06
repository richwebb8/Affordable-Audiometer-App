using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour
{
    public Dropdown dropdown;
    public Canvas selectedTest;
    public Sprite[] sprites;

    /* public void Dropdown_IndexChanged(int index)
    {
        if(index == 0)
        {
            GameObject.FindGameObjectWithTag("BoneConductionCanvas").GetComponent<Canvas>().enabled = false;
            GameObject.FindGameObjectWithTag("AirConductionCanvas").GetComponent<Canvas>().enabled = true;
        }

        if(index == 1)
        {
            GameObject.FindGameObjectWithTag("AirConductionCanvas").GetComponent<Canvas>().enabled = false;
            GameObject.FindGameObjectWithTag("BoneConductionCanvas").GetComponent<Canvas>().enabled = true;
        }
    } */

    private void Start()
    {
        // GameObject.FindGameObjectWithTag("BoneConductionCanvas").GetComponent<Canvas>().enabled = false;
        List<Dropdown.OptionData> spriteItems = new List<Dropdown.OptionData>();
        foreach(var icon in sprites)
        {
            var spriteOption = new Dropdown.OptionData(icon.name,icon);
            spriteItems.Add(spriteOption);
        }
        dropdown.AddOptions(spriteItems);
    }
}
