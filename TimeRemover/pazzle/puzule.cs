using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using VRTK;

public class puzule : MonoBehaviour
{

    public GameObject parent;


    void Start()
    {
       // GetComponent<VRTK_InteractableObject>();
    }

    void Update()
    {
        //this.GetComponent<VRTK_InteractableObject>().enabled = true;
        parent = transform.parent.gameObject;
    }
    /*void OnTriggerStay()
    {

    }*/
    void OnTriggerEnter(Collider col)
    {
        //this.GetComponent<VRTK_InteractableObject>().enabled = false;

        if (col.gameObject.tag == "1")
        {
            transform.parent = GameObject.Find("1").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "2")
        {
            transform.parent = GameObject.Find("2").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "3")
        {
            transform.parent = GameObject.Find("3").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "4")
        {
            transform.parent = GameObject.Find("4").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "5")
        {
            transform.parent = GameObject.Find("5").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "6")
        {
            transform.parent = GameObject.Find("6").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "7")
        {
            transform.parent = GameObject.Find("7").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "8")
        {
            transform.parent = GameObject.Find("8").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
        if (col.gameObject.tag == "9")
        {
            transform.parent = GameObject.Find("9").transform;
            transform.localPosition = new Vector3(0, 0, 0);
        }
    }
}

