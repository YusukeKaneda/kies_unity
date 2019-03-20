using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmove2 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (turecheck.flag3 == 1) {
			GetComponent<Animator>().SetTrigger ("once");
			turecheck.flag3 = 0;
		}
	}
}
