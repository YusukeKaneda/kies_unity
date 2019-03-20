using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check9 : MonoBehaviour {

    public static float flg9;
    public static int ture9;

    void OnTriggerStay(Collider col)
    {
        flg9 = 1;
        if (col.gameObject.tag == "piece9")
        {
            ture9 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg9 = 0;
        ture9 = 0;
    }
}
