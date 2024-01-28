using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIforScore : MonoBehaviour
{
    GUIStyle scorefont;

    private int Score;
    // Start is called before the first frame update
    void Start()
    {
        scorefont = new GUIStyle();

        scorefont.normal.textColor = Color.blue;
        scorefont.fontSize = 30;
    }

    public void SetScore(int score)
    {
        Score = score;
    }

    // Update is called once per frame
    void Update()
    {

        //OnGUI();
    }
    private void OnGUI()
    {

        GUI.Label (new Rect(1000, 15, 100, 100), "Score = " + Score.ToString(), scorefont);

        

    }
}
