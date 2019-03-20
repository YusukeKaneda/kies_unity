using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openmove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pushnumber.flag == 1) {
			GetComponent<Animator>().SetTrigger ("once");
			pushnumber.flag = 0;
		}
	}
}
