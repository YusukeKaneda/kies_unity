using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using VRTK;

public class oculusray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (OVRInput.GetDown(OVRInput.RawButton.X))
        {
            Ray();
			Debug.Log ("a");
        }
        if (OVRInput.GetUp(OVRInput.RawButton.X))
        {

        }
		if (/*device.GetPress(SteamVR_Controller.ButtonMask.Trigger) || */OVRInput.GetDown(OVRInput.RawButton.LIndexTrigger)) {
			Debug.Log ("b");
		}
	}

    void Ray()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(ray.origin, ray.direction, Color.blue,10.0f);
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit, 10.0f))
        {
            GameObject peice = hit.collider.gameObject;
            string objectName = hit.collider.gameObject.name;
            Debug.Log(objectName);
            move mo = peice.GetComponent<move>();
            mo.cmove();
        }
    }
}