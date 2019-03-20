using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check5 : MonoBehaviour {

    public static float flg5;
    public static int ture5;

    void OnTriggerStay(Collider col)
    {
        flg5 = 1;
        if (col.gameObject.tag == "piece5")
        {
            ture5 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg5 = 0;
        ture5 = 0;
    }
}