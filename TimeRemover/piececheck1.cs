namespace VRTK
{
	using System.Collections;
	using System.Collections.Generic;
	using UnityEngine;

	public class piececheck1 : MonoBehaviour {
		public VRTK_InteractableObject ppart1;

		// Use this for initialization
		void Start () {

		}
		
		// Update is called once per frame
		void Update () {
			
		}
		void OnTriggerStay(Collider p1){
			if (p1.gameObject.tag == "zone1") {
				ppart1.GetComponent<VRTK_InteractableObject>().isGrabbable = false;
			}
		}
	}
}