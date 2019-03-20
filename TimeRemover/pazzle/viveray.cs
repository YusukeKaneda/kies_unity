using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class viveray : MonoBehaviour
{
    public float distance;
    public Camera cam;
    void OnEnable()
    {
        if (GetComponent<VRTK_ControllerEvents>() == null)
            return;
        GetComponent<VRTK_ControllerEvents>().TriggerPressed += TriggerPressedHandler;
    }

    void OnDisable()
    {
        if (GetComponent<VRTK_ControllerEvents>() == null)
            return;
        GetComponent<VRTK_ControllerEvents>().TriggerPressed -= TriggerPressedHandler;
    }

    void TriggerPressedHandler(object sender, ControllerInteractionEventArgs e)
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Ray viveRay = cam.ScreenPointToRay(UnityEngine.XR.InputTracking.GetLocalPosition(UnityEngine.XR.XRNode.LeftHand));
        Debug.DrawRay(ray.origin, ray.direction, Color.blue, 3.0f);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, distance))
        {
            GameObject peice = hit.collider.gameObject;
            move mo = peice.GetComponent<move>();
            mo.cmove();
        }
    }

}