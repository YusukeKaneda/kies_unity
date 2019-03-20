using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class vrtkray : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GetComponent<VRTK_ControllerEvents> ().TriggerClicked += new ControllerInteractionEventHandler (DoTriggerClicked);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void DoTriggerClicked(object sender,ControllerInteractionEventArgs e){
		Ray ();
	}

	void Ray(){
		Ray ray = new Ray (transform.position, transform.forward);
		Debug.DrawRay (ray.origin, ray.direction, Color.blue, 10.0f);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, 10.0f)) {
			GameObject peice = hit.collider.gameObject;
			string objectName = hit.collider.gameObject.name;
			Debug.Log (objectName);
			move mo = peice.GetComponent<move> ();
			mo.cmove ();
		}
	}
}
