using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    public GameObject parent;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        parent = transform.parent.gameObject;
    }

    public void cmove()
    {
        if (parent.name == "1")
        {
            m1();
        }
        else if (parent.name == "2")
        {
            m2();
        }
        else if (parent.name == "3")
        {
            m3();
        }
        else if (parent.name == "4")
        {
            m4();
        }
        else if (parent.name == "5")
        {
            m5();
        }
        else if (parent.name == "6")
        {
            m6();
        }
        else if (parent.name == "7")
        {
            m7();
        }
        else if (parent.name == "8")
        {
            m8();
        }
        else if (parent.name == "9")
        {
            m9();
        }
    }

    void m1()
    {
        if (check2.flg2 == 0)
        {
            NMove();
        }
        else if (check4.flg4 == 0)
        {
            EMove();
        }
    }
    void m2()
    {
        if (check1.flg1 == 0)
        {
            SMove();
        }
        else if (check3.flg3 == 0)
        {
            NMove();
        }
        else if (check5.flg5 == 0)
        {
            EMove();
        }
    }
    void m3()
    {
        if (check2.flg2 == 0)
        {
            SMove();
        }
        else if (check6.flg6 == 0)
        {
            EMove();
        }
    }
    void m4()
    {
        if (check1.flg1 == 0)
        {
            WMove();
        }
        else if (check5.flg5 == 0)
        {
            NMove();
        }
        else if (check7.flg7 == 0)
        {
            EMove();
        }
    }
    void m5()
    {
        if (check4.flg4 == 0)
        {
            SMove();
        }
        else if (check6.flg6 == 0)
        {
            NMove();
        }
        else if (check2.flg2 == 0)
        {
            WMove();
        }
        else if (check8.flg8 == 0)
        {
            EMove();
        }
    }
    void m6()
    {
        if (check5.flg5 == 0)
        {
            SMove();
        }
        else if (check3.flg3 == 0)
        {
            WMove();
        }
        else if (check9.flg9 == 0)
        {
            EMove();
        }
    }
    void m7()
    {
        if (check4.flg4 == 0)
        {
            WMove();
        }
        else if (check8.flg8 == 0)
        {
            NMove();
        }
    }
    void m8()
    {
        if (check7.flg7 == 0)
        {
            SMove();
        }
        else if (check5.flg5 == 0)
        {
            WMove();
        }
        else if (check9.flg9 == 0)
        {
            NMove();
        }
    }
    void m9()
    {
        if (check8.flg8 == 0)
        {
            SMove();
        }
        else if (check6.flg6 == 0)
        {
            WMove();
        }
    }

    void NMove()
    {
        this.transform.localPosition += new Vector3(0, 0, 0.01f);
    }
    void EMove()
    {
        this.transform.localPosition += new Vector3(0.01f, 0, 0);
    }
    void SMove()
    {
        this.transform.localPosition += new Vector3(0, 0, -0.01f);
    }
    void WMove()
    {
        this.transform.localPosition += new Vector3(-0.01f, 0, 0);
    }
}
