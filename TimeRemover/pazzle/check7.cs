using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check7 : MonoBehaviour {

    public static float flg7;
    public static int ture7;

    void OnTriggerStay(Collider col)
    {
        flg7 = 1;
        if (col.gameObject.tag == "piece7")
        {
            ture7 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg7 = 0;
        ture7 = 0;
    }
}
