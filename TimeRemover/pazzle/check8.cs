using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check8 : MonoBehaviour {

    public static float flg8;
    public static int ture8;

    void OnTriggerStay(Collider col)
    {
        flg8 = 1;
        if (col.gameObject.tag == "piece8")
        {
            ture8 = 1;
        }
    }
    void OnTriggerExit()
    {
        flg8 = 0;
        ture8 = 0;
    }
}