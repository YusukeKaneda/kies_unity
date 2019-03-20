using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hassya2 : MonoBehaviour {

    public GameObject bullet;
    public Rigidbody rb;
    public Transform muzzle;
    public float timer = 0;
    public static float interval = 6;
    public static int cnt = 0;
    public static int max = 30;
    public float speed;
    // Use this for initialization
    void Start()
    {
        cnt = 0;
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= interval)
        {
            cnt++;
            if (cnt != 0 && cnt <= max)
            {
                Spown();
            }
            timer = 0;

        }
        
    }

    void Spown()
    {
        GameObject bullets = Instantiate(bullet) as GameObject;
        rb = bullets.GetComponent<Rigidbody>();
        rb.AddForce(0,0,-speed,ForceMode.VelocityChange);
        bullets.transform.position = muzzle.position;
    }
}
