using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Profiling;
using UnityEngine;

public class lab3ProblemB : MonoBehaviour
{
    public double coverPrice;
    public int numPurchased;
    // Start is called before the first frame update
    void Start()
    {
        TotalCost(coverPrice, numPurchased);
    }
    void TotalCost(double a, int b)
    {
        double coverDiscounted = coverPrice * .60;
        Debug.Log("The book will cost " + coverDiscounted + " each with the discount.");

        double totalShipping = 3 + (numPurchased - 1) * .75;
        Debug.Log("Shipping will cost " + totalShipping);

        double costToBuy = (coverDiscounted * numPurchased) + totalShipping;

        //inferring all books bought are sold
        double profit = (numPurchased * coverPrice) - costToBuy;
        Debug.Log("The total profit is " + profit);
    }
}