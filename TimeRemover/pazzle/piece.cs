using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;


public class piece : MonoBehaviour {

    public GameObject[] numpiece;
    Vector3[] ppositions = new Vector3[]
    {
        new Vector3(-0.005028f,0,-0.005075f),
        new Vector3(-0.005028f,0,0.004993f),
        new Vector3(-0.005028f,0,0.0149517f),
        new Vector3(0.0049848f,0,-0.005075f),
        new Vector3(0.0049848f,0,0.004993f),
        new Vector3(0.0049848f,0,0.0149517f),
        new Vector3(0.0151068f,0,-0.005075f),
        new Vector3(0.0151068f,0,0.004993f),
        new Vector3(0.0151068f,0,0.0149517f)
    };

    void Start()
    {
        var ary = Enumerable.Range(0, 9).OrderBy(n => Guid.NewGuid()).Take(8).ToArray();
        if (ary[0] == 4 && ary[1] == 7 && ary[2] == 8 && ary[3] == 5 && ary[4] == 2 && ary[5] == 1 && ary[6] == 3 && ary[7] == 6)
        {
            ary = Enumerable.Range(0, 9).OrderBy(n => Guid.NewGuid()).Take(8).ToArray();
        }
        for (int i = 0; i < 8; i++)
        {
            numpiece[i].transform.localPosition = ppositions[ary[i]];
        }
    }
}