using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public float score = 10;
    public GameObject explosion;
    private bool isQuitting = false;
    public ScoreSystem Score;

    void Start()
    {
        Score = GameObject.Find("ScoreSystem").GetComponent<ScoreSystem>();
    }

    void Damege()
    {
        Destroy(gameObject);
    }

    void OnApplicationQuit()
    {
        isQuitting = true;
    }
    void OnDestroy()
    {
        if (!isQuitting)
        {
            GameObject.Instantiate(explosion, transform.position, Quaternion.identity);
            Score.AddScore(score);
        }
    }
}

