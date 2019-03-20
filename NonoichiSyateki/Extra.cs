using UnityEngine;
using System.Collections;

public class Extra : MonoBehaviour {

	public ScoreSystem add;
	public float extraScore = 10;

	void Start(){
		add = GameObject.Find("ScoreSystem").GetComponent<ScoreSystem>();
	}

	void OnTriggerEnter (Collider col){

		if (col.gameObject.tag == "Plane"){
			add.AddScore(extraScore);
		}
	}
}