using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check4 : MonoBehaviour {

    public static float flg4;
    public static int ture4;

    void OnTriggerStay(Collider col)
    {
        flg4 = 1;
        if (col.gameObject.tag == "piece4")
        {
            ture4 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg4 = 0;
        ture4 = 0;
    }
}