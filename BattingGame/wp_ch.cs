using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wp_ch : MonoBehaviour {
    public GameObject wp1;
    public GameObject wp2;
    public GameObject wp3;
    public GameObject wp4;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Touchpad))
        {
            Vector2 position = device.GetAxis();
            if (position.y / position.x > 1 || position.y / position.x < -1)
            {
                if (position.y > 0)
                {
                    wp1.SetActive(true);
                    wp2.SetActive(false);
                    wp3.SetActive(false);
                    wp4.SetActive(false);
                    GetComponent<shot>().enabled = false;
                }
                else
                {
                    wp1.SetActive(false);
                    wp2.SetActive(true);
                    wp3.SetActive(false);
                    wp4.SetActive(false);
                    GetComponent<shot>().enabled = false;
                }
            }
            else
            {
                if (position.x > 0)
                {
                    wp1.SetActive(false);
                    wp2.SetActive(false);
                    wp3.SetActive(true);
                    wp4.SetActive(false);
                    GetComponent<shot>().enabled = true;
                }
                else
                {
                    wp1.SetActive(false);
                    wp2.SetActive(false);
                    wp3.SetActive(false);
                    wp4.SetActive(true);
                    GetComponent<shot>().enabled = false;
                }
            }
        }
	}
}
