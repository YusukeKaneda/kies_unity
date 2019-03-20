using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check2 : MonoBehaviour {

    public static float flg2;
    public static int ture2;

    void OnTriggerStay(Collider col)
    {
        flg2 = 1;
        if (col.gameObject.tag == "piece2")
        {
            ture2 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg2 = 0;
        ture2 = 0;
    }
}
