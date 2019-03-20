using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class choose1 : MonoBehaviour
{
    public float endtime = 0;
    public float nexttime = 0;
    public Camera cam;
    public Transform line;

    // Use this for initialization
    void Start()
    {
        endtime = 0;
        nexttime = 0;

    }
    void Update()
    {
        SteamVR_TrackedObject trackedObject = GetComponent<SteamVR_TrackedObject>();
        var device = SteamVR_Controller.Input((int)trackedObject.index);
        if (device.GetPress(SteamVR_Controller.ButtonMask.Trigger))
        {
            Ray();
            line.gameObject.SetActive(true);
        }
        if (device.GetPressUp(SteamVR_Controller.ButtonMask.Trigger))
        {
            line.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Ray()
    {


        Ray ray = new Ray(transform.position, transform.forward);
        Ray viveRay = cam.ScreenPointToRay(UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.LeftHand));
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 3.0f);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 20.0f))
        {
            if (hit.collider.gameObject.tag == "end")
            {
                endtime += Time.deltaTime;
                if (endtime >= 1.0f)
                {
                    SceneManager.LoadScene("ending");
                }
            }
            else if (hit.collider.gameObject.tag == "next")
            {

                nexttime += Time.deltaTime;
                if (nexttime >= 1.0f)
                {
                    SceneManager.LoadScene("last");
                }
            }

        }
    }
}

