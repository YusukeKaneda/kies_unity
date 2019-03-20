using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkray : MonoBehaviour {

    public float distance = 100;
    public static int flg = 0;
    public Camera subcam;

    void Start()
    {
        Rigidbody rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = subcam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(ray, out hit, distance))
            {
                GameObject peice = hit.collider.gameObject;
                // string objectName = hit.collider.gameObject.name;
                //Debug.Log(objectName);
                move mo = peice.GetComponent<move>();
                mo.cmove();
            }
        }
    }
}


