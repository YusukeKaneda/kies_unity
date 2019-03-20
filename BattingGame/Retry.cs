using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    public float endtime = 0;
    public float contime = 0;
    public Camera cam;
    public Transform line;

    // Use this for initialization
    void Start()
    {

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
                    SceneManager.LoadScene("tiittle_BattingShotBattle");
                }
            }
            else if (hit.collider.gameObject.tag == "continue")
            {
                contime += Time.deltaTime;

                if (contime >= 1.0f)
                {
                    SceneManager.LoadScene("batting");
                }
            }

        }
    }
}


