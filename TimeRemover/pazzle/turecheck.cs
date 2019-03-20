using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turecheck : MonoBehaviour {

    public int ture;
    public GameObject turebload;
	public static int flag3 = 0;
	public GameObject part3;
    void Update()
    {
        ture = check1.ture1 + check2.ture2 + check3.ture3 + check4.ture4 + check5.ture5 + check6.ture6 + check7.ture7 + check8.ture8 + check9.ture9;
        if (ture >= 8)
        {
            answer();
        }
    }

    void answer()
    {
        this.gameObject.SetActive(false);
        turebload.gameObject.SetActive(true);
		flag3 = 1;
		part3.SetActive(true);
    }
}