using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textToBold : MonoBehaviour {

    public Toggle thisToggle;

    private Text[] GetText;

    public void changeFontStyle()
    {
        GetText = Text.FindObjectsOfType<Text>();

        if (thisToggle.isOn)
        {
            foreach (Text go in GetText)
            {
                go.fontStyle = FontStyle.Bold;
            }
        }
        else
        {
            foreach (Text go in GetText)
            {
                go.fontStyle = FontStyle.Normal;
            }

        }
    }
}
