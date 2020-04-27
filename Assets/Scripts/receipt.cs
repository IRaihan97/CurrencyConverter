using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class receipt : MonoBehaviour {

    private Text receiptText;
    public gbpConvs ConvOut;
    public getInput UserIn;
    public clock passTime;
    double charge;
    double totalcost;


    // Use this for initialization
    void Start () {
        receiptText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        if (UserIn.getValue() < 100)
        {
            charge = 0;
        }

        else if (UserIn.getValue() >= 100 && UserIn.getValue() <= 500)
        {
            charge = UserIn.getValue() * 0.01;
        }

        else if (UserIn.getValue() >= 500 && UserIn.getValue() <= 1000)
        {
            charge = UserIn.getValue() * 0.02;
        }

        else
        {
            charge = UserIn.getValue() * 0.03;
        }
        totalcost = charge + UserIn.getValue();
        receiptText.text = "Receipt" +
                           "\nAddress:" +
                           "\n1A Uxbridge Street" +
                           "\nUB3 3BB" +
                           "\nUxbride" +
                           "\nMiddlsex" +
                           "\n" +
                            "\nUser Name: " + UserIn.getUsername() +
                            "\nUser Surname: " + UserIn.getUserSurn() +
                            "\nUser ID: " + UserIn.getUserID() +
                            "\nClient Name:" + UserIn.getClient() +
                            "\nTime: " + passTime.getTime() +
                            "\nDate: " + passTime.getDate() +
                            "\nMoney Inserted: " + UserIn.getValue() + " " + ConvOut.getCurrencyIn() +
                            "\nConverted To: " + ConvOut.getResult() + " " + ConvOut.getCurrencyOut() +
                            "\nTotal Charge: " + totalcost + " " + ConvOut.getCurrencyIn();
        


    }
}
