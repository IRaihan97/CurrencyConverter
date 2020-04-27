using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getInput : MonoBehaviour
{
    //Inputs from user
    [SerializeField]
    private InputField userinput;

    [SerializeField]
    private InputField userName;

    [SerializeField]
    private InputField userSurn;

    [SerializeField]
    private InputField userID;

    [SerializeField]
    private InputField clientName;

    //Local variable to store inputs from user
    static double value;
    static string staffName;
    static string staffSurn;
    static string staffID;
    static string clntName;

    public void GetInput(string input)
    {
        value = double.Parse(input);
        Debug.Log("Entered: " + value);
        userinput.text = "";

    }

    public void NameInput(string name)
    {
        staffName = name;
        userName.text = "";
        Debug.Log("Entered: " + staffName);
    }

    public void SurnameInput(string surname)
    {
        staffSurn = surname;
        userSurn.text = "";
        Debug.Log("Entered: " + staffSurn);
    }

    public void IDInput(string ID)
    {
        staffID = ID;
        userID.text = "";
        Debug.Log("Entered: " + staffID);
    }

    public void ClientInput(string client)
    {
        clntName = client;
        clientName.text = "";
        Debug.Log("Entered: " + clntName);
    }

    public double getValue()
    {
        return value;
    }

    public string getUsername()
    {
        return staffName;
    }

    public string getUserSurn()
    {
        return staffSurn;
    }

    public string getUserID()
    {
        return staffID;
    }

    public string getClient()
    {
        return clntName;
    }


}