using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anothoerp : MonoBehaviour {
	public static int pres = 0;
	public int p = 0;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()
	{
		p = pres;
		var trackedObject = GetComponent<SteamVR_TrackedObject> ();
		var device = SteamVR_Controller.Input ((int)trackedObject.index);
		if (device.GetPress (SteamVR_Controller.ButtonMask.Touchpad)) {
			pres += 5;
			Debug.Log ("on");
		} else {
			pres -= 1;
		}
		if (pres < 0) {
			pres = 0;
		}
		if (pres > 300) {
			pres = 300;
		}
	}
}
