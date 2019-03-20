using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check1 : MonoBehaviour {

    public static float flg1;
    public static int ture1;

    void OnTriggerStay(Collider col)
    {
        flg1 = 1;
        if (col.gameObject.tag == "piece1")
        {
            ture1 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg1 = 0;
        ture1 = 0;
    }
}
