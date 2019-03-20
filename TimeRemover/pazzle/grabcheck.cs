using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class grabcheck : MonoBehaviour {

    public GameObject grab;

	// Use this for initialization
	void Start () {
        GetComponent<VRTK_InteractableObject>();
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<VRTK_InteractableObject>().enabled = true;
	}
    void OnTriggerStay()
    {
        this.GetComponent<VRTK_InteractableObject>().enabled = true;
    }

}
