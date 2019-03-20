using UnityEngine;
using System.Collections;


public class ScoreSystem : MonoBehaviour
{

    private GUIStyle style;
    public static float score = 0;

    void Start()
    {
        style = new GUIStyle();
        style.fontSize = 40;
    }

    public void AddScore(float addScore)
    {
        score += addScore;
    }


    void OnGUI()
    {
        Rect rect = new Rect(10, 10, 400, 300);
        GUI.Label(rect, "Score:" + score, style);
    }

    public static float getpoint()
    {
        return score;
    }

}