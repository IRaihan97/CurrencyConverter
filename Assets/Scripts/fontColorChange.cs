using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fontColorChange : MonoBehaviour {

    public Toggle thisToggle;

    private Text[] GetText;

    public Color newColor;

    public Color defaultcolor;

    public void changeFontColor()
    {
        GetText = Text.FindObjectsOfType<Text>();

        if (thisToggle.isOn)
        {
            foreach (Text go in GetText)
            {
                go.color = newColor;
            }
        }
        else
        {
            foreach (Text go in GetText)
            {
                go.color = defaultcolor;
            }

        }
    }
}