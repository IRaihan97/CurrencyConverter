using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gbpConvs : MonoBehaviour {

    private GameObject container;
    public Button[] currencies;
    public getInput money;
    int i;
    static double moneyIn;
    static double result;
    static double rate;
    string currTypeIn;
    string currTypeOut;

    // Use this for initialization
    void Start()
    {
        container = this.gameObject;
        currencies = container.GetComponentsInChildren<Button>();
        for (i = 0; i < currencies.Length; i++)
        {
            int iterator = i;
            currencies[i].onClick.AddListener(() => conversion(iterator));

        }
    }


    public void conversion(int index)
    {   
        //FromGBP
        if (index == 0)
        {
            //USD
            moneyIn = money.getValue();
            rate = 1.40;
            result = rate * moneyIn;
            currTypeIn = "GBP";
            currTypeOut = "Dollars";
            Debug.Log(result);
            i = 0;
        }
        else if (index == 1)
        {
            //Euro
            moneyIn = money.getValue();
            rate = 1.14;
            result = rate * moneyIn;
            currTypeIn = "GBP";
            currTypeOut = "Euro";
            Debug.Log(result);
            i = 0;
        }
        else if (index == 2)
        {
            //Yen
            moneyIn = money.getValue();
            rate = 149.02;
            result = rate * moneyIn;
            currTypeIn = "GBP";
            currTypeOut = "Yen";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 3)
        {
            //INR
            moneyIn = money.getValue();
            rate = 91.43;
            result = rate * moneyIn;
            currTypeIn = "GBP";
            currTypeOut = "Rupees";
            Debug.Log(result);
            i = 0;
        }

        //FromUSD
        else if (index == 4)
        {
            //GBP
            moneyIn = money.getValue();
            rate = 0.71;
            result = rate * moneyIn;
            currTypeIn = "Dollars";
            currTypeOut = "GBP";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 5)
        {
            //EURO
            moneyIn = money.getValue();
            rate = 0.82;
            result = rate * moneyIn;
            currTypeIn = "Dollars";
            currTypeOut = "Euro";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 6)
        {
            //YEN
            moneyIn = money.getValue();
            rate = 106.53;
            result = rate * moneyIn;
            currTypeIn = "Dollars";
            currTypeOut = "Yen";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 7)
        {
            //INR
            moneyIn = money.getValue();
            rate = 65.25;
            result = rate * moneyIn;
            currTypeIn = "Dollars";
            currTypeOut = "Rupees";
            Debug.Log(result);
            i = 0;
        }

        //FromEUR
        else if (index == 8)
        {
            //GBP
            moneyIn = money.getValue();
            rate = 0.87;
            result = rate * moneyIn;
            currTypeIn = "Euro";
            currTypeOut = "GBP";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 9)
        {
            //USD
            moneyIn = money.getValue();
            rate = 1.22;
            result = rate * moneyIn;
            currTypeIn = "Euro";
            currTypeOut = "Dollars";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 10)
        {
            //YEN
            moneyIn = money.getValue();
            rate = 130.43;
            result = rate * moneyIn;
            currTypeIn = "Euro";
            currTypeOut = "YEN";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 11)
        {
            //INR
            moneyIn = money.getValue();
            rate = 79.87;
            result = rate * moneyIn;
            currTypeIn = "Euro";
            currTypeOut = "Rupees";
            Debug.Log(result);
            i = 0;
        }
        
        //FromYEN
        else if (index == 12)
        {
            //USD
            moneyIn = money.getValue();
            rate = 0.0094;
            result = rate * moneyIn;
            currTypeIn = "YEN";
            currTypeOut = "Dollars";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 13)
        {
            //EURO
            moneyIn = money.getValue();
            rate = 0.0077;
            result = rate * moneyIn;
            currTypeIn = "YEN";
            currTypeOut = "Euro";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 14)
        {
            //GBP
            moneyIn = money.getValue();
            rate = 0.0067;
            result = rate * moneyIn;
            currTypeIn = "YEN";
            currTypeOut = "GBP";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 15)
        {
            //INR
            moneyIn = money.getValue();
            rate = 0.61;
            result = rate * moneyIn;
            currTypeIn = "YEN";
            currTypeOut = "Rupees";
            Debug.Log(result);
            i = 0;
        }

        //FromINR
        else if (index == 16)
        {
            //USD
            moneyIn = money.getValue();
            rate = 0.015;
            result = rate * moneyIn;
            currTypeIn = "Rupees";
            currTypeOut = "Dollars";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 17)
        {
            //EURO
            moneyIn = money.getValue();
            rate = 0.013;
            result = rate * moneyIn;
            currTypeIn = "Rupees";
            currTypeOut = "Euro";
            Debug.Log(result);
            i = 0;
        }

        else if (index == 18)
        {
            //YEN
            moneyIn = money.getValue();
            rate = 1.63;
            result = rate * moneyIn;
            currTypeIn = "Rupees";
            currTypeOut = "YEN";
            Debug.Log(result);
            i = 0;
        }

        else
        {
            //GBP
            moneyIn = money.getValue();
            rate = 0.011;
            result = rate * moneyIn;
            currTypeIn = "Rupees";
            currTypeOut = "GBP";
            Debug.Log(result);
            i = 0;
        }

    }

    public double getResult()
    {
        return result;
    }

    public string getCurrencyIn()
    {
        return currTypeIn;
    }

    public string getCurrencyOut()
    {
        return currTypeOut;
    }
}
