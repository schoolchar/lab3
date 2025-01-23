using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class money : MonoBehaviour
{
    public int total;

    // Start is called before the first frame update
    void Start()
    {
        total = 125;
        paid();
    }

    // Update is called once per frame
    void paid()
    {
        Debug.Log(total);
        int hundred = total / 100;
        Debug.Log(total);
        total %= 100;
        Debug.Log(total);

        int fiftie = total / 50;
        Debug.Log(total);
        total %= 50;
        Debug.Log(total);

        int twenty = total / 20;
        Debug.Log(total);
        total %= 20;
        Debug.Log(total);

        int ten = total / 10;
        total %= 10;

        int five = total / 5;
        total %= 5;

        int ones = total;

        Debug.Log(total);
        Debug.Log(hundred);
        Debug.Log(fiftie);
        Debug.Log(twenty);
        Debug.Log(ten);
        Debug.Log(five);

    }
}
