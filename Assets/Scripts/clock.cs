using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class clock : MonoBehaviour {

    private Text realclock;
    string date;
    string time;

    void Start()
    {
        realclock = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        DateTime theTime = DateTime.Now;
        date = theTime.ToString("yyyy-MM-dd");
        time = theTime.ToString("HH:mm:ss");

        realclock.text = time;
	}

    public string getTime()
    {
        return time;
    }

    public string getDate()
    {
        return date;
    }
}
