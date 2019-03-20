﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class left_hand : MonoBehaviour {

	public Transform center_box;
	public float y_rote;
	public float rotate;
	public static bool leftcheck;
	// Use this for initialization
	void Start () {
		y_rote = center_box.transform.eulerAngles.y;
	}
	
	// Update is called once per frame
	void Update () {
		y_rote = center_box.transform.eulerAngles.y;
	}

    private void OnTriggerEnter(Collider col)
	{
		if (TimelineController.EventFlag == 0) {
			if (col.gameObject.tag == "flont") {
				idou.left_flg = 2;
				Debug.Log ("left_flont_touch");
				Debug.Log (idou.left_flg);
				idou.cnt++;
			}

			if (col.gameObject.tag == "back") {
				idou.left_flg = 1;
				idou.cnt++;
			}

		}
		if (TimelineController.EventFlag == 1) {
			if (col.gameObject.tag == "flont") {
				Debug.Log ("flying_left_touch.l:" + y_rote);
				if (y_rote >= 120 && y_rote <= 240) {
					center_box.transform.Rotate (new Vector3 (0, rotate, 0));
					y_rote = center_box.transform.eulerAngles.y;
					Debug.Log ("flying_left_touch.l:" + y_rote);
				}
				else if (y_rote > 240) {
					leftcheck = true;
				}
				if (right_hand.rightcheck == true) {
					center_box.transform.Rotate (new Vector3 (0, rotate, 0));
					y_rote = center_box.transform.eulerAngles.y;
					Debug.Log ("flying_left_touch.l:" + y_rote);
					if (y_rote > 120) {
						right_hand.rightcheck = false;
					}
				}
			}
		}
	}
		
}
