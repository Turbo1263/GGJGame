using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreboard_red : MonoBehaviour
{
    GUIStyle scorefont;

    public static int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        scorefont = new GUIStyle();

        scorefont.normal.textColor = Color.red;
        scorefont.fontSize = 30;
    }




    // Update is called once per frame
    void Update()
    {

    }
    private void OnGUI()
    {
       
        GUI.Label(new Rect(10, 15, 200, 100), "Score = " + Score.ToString(), scorefont);



    }
}
