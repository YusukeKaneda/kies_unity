using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using VRTK;

public class RightHandAnimationControl : MonoBehaviour {
	public Animator Right;
	void Start () {		
		Right = GetComponent<Animator> ();	
	}

	void Update () {
		/*var trackedObject = GetComponent<SteamVR_TrackedObject>();
		var device = SteamVR_Controller.Input((int)trackedObject.index);

		if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) {
			pushon ();
		} else if(device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger) || OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger)) {
			pushoff ();
		}
		if  (device.GetPress(SteamVR_Controller.ButtonMask.Grip) || OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)) {
			grabon ();
		} else if (device.GetTouchUp(SteamVR_Controller.ButtonMask.Grip) || OVRInput.GetUp(OVRInput.RawButton.RHandTrigger)) {
			graboff ();
		}*/
		if (OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger)) {
			pushon ();
		} else if(OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger)) {
			pushoff ();
		}
		if  (OVRInput.GetDown(OVRInput.RawButton.RHandTrigger)) {
			grabon ();
		} else if (OVRInput.GetUp(OVRInput.RawButton.RHandTrigger)) {
			graboff ();
		}
	}
	void pushon(){
		Right.SetBool ("push", true);
	}
	void pushoff(){
		Right.SetBool ("push",false);
	}
	void grabon(){
		Right.SetBool ("grab", true);
	}
	void graboff(){
		Right.SetBool ("grab", false);
	}
}