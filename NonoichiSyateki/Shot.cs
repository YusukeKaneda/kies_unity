using UnityEngine;
using System.Collections;

public class Shot : MonoBehaviour {
	public GameObject bullet;
	public Transform spawn;
	public float speed = 1000;
	private int timer;
	public int rate;
	private int flg = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(flg == 1){
			timer++;
			if(timer == rate){
				flg = 0;
				timer = 0;
			}
		}
		if (Input.GetMouseButton (0) && timer == 0) {
			Shoot ();
		}
	}
	void Shoot(){
		GameObject obj = GameObject.Instantiate (bullet)as GameObject;
		obj.transform.position = spawn.position;
		Vector3 force;
		force = this.gameObject.transform.forward * speed;
		obj.GetComponent<Rigidbody> ().AddForce (force);
		flg = 1;
	}
}
