using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    public Transform s;
    public GameObject b;
    public Rigidbody rb;
    public float speed;
    public GameObject canpas;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        SteamVR_TrackedObject track = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)track.index);
        if (device.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
        {

            GameObject bs = Instantiate(b) as GameObject;
            rb = bs.GetComponent<Rigidbody>();
            rb.AddForce(0, 0, speed, ForceMode.VelocityChange);
            bs.transform.position = s.position;
            canpas.SetActive(true);
            GetComponent<shot>().enabled = false;
        }

    }
}
