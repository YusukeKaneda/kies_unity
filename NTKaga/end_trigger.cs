using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class end_trigger : MonoBehaviour {
    public GameObject text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player"){
            text.GetComponent<owari>().enabled = true;
        }
    }
}
