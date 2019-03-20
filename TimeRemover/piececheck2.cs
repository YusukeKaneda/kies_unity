namespace VRTK
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class piececheck2 : MonoBehaviour {
		public VRTK_InteractableObject ppart2;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
		void OnTriggerStay(Collider p2){
			if (p2.gameObject.tag == "zone2") {
				ppart2.GetComponent<VRTK_InteractableObject>().isGrabbable = false;

			}
		}
	}
}