using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmove1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (pushnumber2.flag2 == 1) {
			GetComponent<Animator>().SetTrigger ("once");
			pushnumber2.flag2 = 0;
		}
	}
}
