using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check6 : MonoBehaviour {

    public static float flg6;
    public static int ture6;

    void OnTriggerStay(Collider col)
    {
        flg6 = 1;
        if (col.gameObject.tag == "piece6")
        {
            ture6 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg6 = 0;
        ture6 = 0;
    }
}