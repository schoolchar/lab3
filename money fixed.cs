using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public int total;

    // Start is called before the first frame update
    void Start()
    {
        //calls function
        paid();
    }

    // Update is called once per frame
    void paid()
    {
        //division wont have a decimal
        //goes though each number and spits out whats needed

        //goes through $100 dollar bills and sets "hundreds" to total divided by 100 and cuts off the decimal,
        //same goes for each variable but different number
        int hundred = total / 100;
        total %= 100;

        int fiftie = total / 50;
        total %= 50;

        int twenty = total / 20;
        total %= 20;

        int ten = total / 10;
        total %= 10;

        int five = total / 5;
        total %= 5;

        int ones = total;



        Debug.Log($"you owe{hundred}$100 bills");
        Debug.Log($"you owe{fiftie}$50 bills");
        Debug.Log($"you owe{twenty}$20 bills");
        Debug.Log($"you owe{ten}$10 bills");
        Debug.Log($"you owe{five}$5 bills");
        Debug.Log($"you owe{ones}$1 bills");
    }
}
