using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.VR;
using UnityEngine;


public class startgame : MonoBehaviour
{
    public Camera cam;
    public Transform line;
    public static float che;

    // Use this for initialization
    void Start()
    {
        che = 0;
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
        Ray viveRay = cam.ScreenPointToRay(UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.RightHand));
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 20.0f);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Mathf.Infinity))
        {
            if (hit.collider.gameObject.tag == "buttan")
            {

                che += Time.deltaTime;
                if (che >= 1.0f)
                {
                    SceneManager.LoadScene("setumei");
                }
            }

        }
    }

}
