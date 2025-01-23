using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lab3ProblemC : MonoBehaviour
{
    public int paidMoney;

    // Start is called before the first frame update
    void Start()
    {
        CalculateBills();
    }

    void CalculateBills()
    {
        if (paidMoney >= 100)
        {
            int hundredBills = paidMoney / 100;
            paidMoney = paidMoney - (hundredBills * 100);
            Debug.Log("You will be paid " + hundredBills + " 100 dollar bills");
        }

        if (paidMoney >= 50)
        {
            int fiftyBills = paidMoney / 50;
            paidMoney = paidMoney - (fiftyBills * 50);
            Debug.Log("You will be paid " + fiftyBills + " 50 dollar bills");
        }

        if (paidMoney >= 20)
        {
            int twentyBills = paidMoney / 20;
            paidMoney = paidMoney - (twentyBills * 20);
            Debug.Log("You will be paid " + twentyBills + " 20 dollar bills");
        }

        if (paidMoney >= 5)
        {
            int fiveBills = paidMoney / 5;
            paidMoney = paidMoney - (fiveBills * 5);
            Debug.Log("You will be paid " + fiveBills + " 5 dollar bills");
        }

        if (paidMoney >= 1)
        {
            int oneBills = paidMoney;
            Debug.Log("You will be paid " + oneBills + " 1 dollar bills");
        }

        
    }

}
