using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour {
	public GameObject player;
	public static float jet = 1000;

	public float lowerLimit = 50;
	public float upperLimit; 

	public Rigidbody g;
	private float jup;
	private float jforword;
	private float hight;

	public float n,m;

	public Transform shotpoint;
	Vector3 pos;
	public float test;

	/*public static float getJet (){
		return jet;
	}*/

	// Use this for initialization
	void Start () {
		g = GetComponent<Rigidbody> ();
		hight = 0;
	}

	// Update is called once per frame
	void Update () {
		
		if (TimelineController.EventFlag == 1) {
			jet = anothoerp.pres / n;
			Debug.Log (jet);
			if (hight < lowerLimit) {
				hight += Time.deltaTime * 5;

			}
			jforword = jet;
			jup = jet;
			if (jet <= 0.5f)
				jup = -20f; //もと-15
			if (jet > 30)
				jet = 30;
			if (jforword < 10)
				jforword = 10;


			g.velocity = new Vector3(0,0,0);
			g.AddRelativeForce(0.0f, jup*100, jforword * -150);
			if (player.transform.position.y > upperLimit) {
				player.transform.position = new Vector3 (player.transform.position.x, upperLimit, player.transform.position.z);
			} else if (player.transform.position.y < hight) {
				player.transform.position = new Vector3 (player.transform.position.x, hight, player.transform.position.z);
			}
		} else if (TimelineController.EventFlag == 2) {
			pos = this.gameObject.transform.position;
			test = pos.y;

			g.useGravity = true;

			if (test > 7) {
				//this.gameObject.transform.position = new Vector3 (pos.x, pos.y - 0.5f, pos.z);
				g.AddRelativeForce(0,0,0);
				this.gameObject.transform.position = new Vector3 (pos.x, pos.y - 0.5f , pos.z);
			} else {
				g.velocity = Vector3.zero;

			}
			//float angle = Mathf.LerpAngle (player.transform.position.y, 0, 0.2f);
			//player.transform.Translate (transform.forward * 10);
			//transform.eulerAngles = new Vector3 (0, angle, 0);
			//player.transform.position = Vector3.Slerp (player.transform.position, shotpoint.transform.position, 0.05f);
		}

		if (TimelineController.PlaneFlag == 1) {
			g.isKinematic = true;
			g.useGravity = false;
			TimelineController.PlaneFlag = 0;
		}
	}
}