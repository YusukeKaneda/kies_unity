using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class timer : MonoBehaviour
{
    private float time = 60;
    public GameObject gameoverText;

    // Use this for initialization
    void Start()
    {
        gameoverText.SetActive(false);
        GetComponent<Text>().text = ((int)time).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            StartCoroutine("gameover");
        }
        if (time < 0) time = 0;
        GetComponent<Text>().text = ((int)time).ToString();
    }
    IEnumerator gameover ()
    {
        gameoverText.SetActive(true);
        yield return new WaitForSeconds(2.0f);
        if (Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel("second");
        }

    }
}

