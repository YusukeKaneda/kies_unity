using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steamray : MonoBehaviour {

    private LineRenderer pointer;

    void Start () {

        pointer = this.GetComponent<LineRenderer>();

        pointer.positionCount = 2;
	}

	void Update () {
        pointer.SetPosition(0, this.transform.position);

        RaycastHit hit;
        
        if(Physics.Raycast(this.transform.position, this.transform.forward*10f,out hit, 100))
        {
            
                pointer.SetPosition(1, hit.point);
                EnablePointer();
                GameObject peice = hit.collider.gameObject;
                move mo = peice.GetComponent<move>();
                mo.cmove();
            
            
        }
        else
        {
            DisEnablePointer();
        }
    }

    private void EnablePointer()
    {
        pointer.enabled = true;
    }

    private void DisEnablePointer()
    {
        pointer.enabled = false;
    }
}
