using UnityEngine;
using System.Collections;

public class Target : MonoBehaviour {
	private int flg;
	public int sflg;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject == null) {
			GameObject.Instantiate(gameObject);
		}
	}
	void OnCollisionEnter (Collision col){
		if (col.gameObject.CompareTag ("yuka") || col.gameObject.CompareTag("out")) {
			Destroy (gameObject);
//			sflg = 1;

		}
	}
}
