using UnityEngine;
using System.Collections;

public class hassya : MonoBehaviour {
    public GameObject bullet;
    public Transform muzzle;
    public static float cnt=0;
    public float speed;
    public static float max = 60;
    public static float den = 5;
    public float end = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cnt += Time.deltaTime;
        if(cnt >= 5)
        {
            if (cnt/den  <= max)
            {
                if (cnt % den >= 0 && cnt % den <= end) 
                {
                    GameObject bullets = Instantiate(bullet) as GameObject;

                    Vector3 force;
                    force = this.gameObject.transform.forward * speed;
                    bullets.GetComponent<Rigidbody>().AddForce(force);
                    bullets.transform.position = muzzle.position;
                }
            }
        }
            
    }
}
