using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class piecegrabcheck : MonoBehaviour {
	public GameObject[] ppiece;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTiggerEnter(Collider pi){
		if (pi.gameObject.tag == "piece1" || pi.gameObject.tag == "piece2" || pi.gameObject.tag == "piece3" || pi.gameObject.tag == "piece4" || pi.gameObject.tag == "piece5" || pi.gameObject.tag == "piece6" || pi.gameObject.tag == "piece8" || pi.gameObject.tag == "piece9") {
			for (int i = 0; i < 8; i++) {
				ppiece [i].GetComponent<puzule> ().enabled = false;
			}
		}
	}
}
