using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check3 : MonoBehaviour {

    public static float flg3;
    public static int ture3;

    void OnTriggerStay(Collider col)
    {
        flg3 = 1;
        if (col.gameObject.tag == "piece3")
        {
            ture3 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg3 = 0;
        ture3 = 0;
    }
}