namespace VRTK
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class piececheck3 : MonoBehaviour {
		public VRTK_InteractableObject ppart3;

		// Use this for initialization
		void Start () {

		}

		// Update is called once per frame
		void Update () {

		}
		void OnTriggerStay(Collider p3){
			if (p3.gameObject.tag == "zone3") {
				ppart3.GetComponent<VRTK_InteractableObject>().isGrabbable = false;
			}
		}
	}
}