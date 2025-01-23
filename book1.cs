using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class book : MonoBehaviour
{
    //X and Y edit variables
    [SerializeField]private float cover;
    [SerializeField]private int sold;

    //non changing variables
    private float discount = 0.6f;
    private int shippingFirst = 3;
    private float shippingAfter = 0.75f;
    private float totalCost;
    private float shipping;
    private float profit;

    // Start is called before the first frame update
    void Start()
    {
        calculateAmount();  
    }

    // Update is called once per frame
    void calculateAmount()
    {
        //apply discount
        totalCost = cover * discount;
        //calculate price for amount sold
        totalCost = totalCost * sold;

        //calculate shipping
        if (sold >= 1)
        {
            shipping = sold - 1;
            shipping = (shipping * shippingAfter) + shippingFirst;
            profit = totalCost - shipping;
        }

        if (sold == 0)
        {
           profit = 0;
        }

        //calculate profit

        Debug.Log($"{totalCost} is the cost");
        Debug.Log($"{profit} is the profit");


    }
}
