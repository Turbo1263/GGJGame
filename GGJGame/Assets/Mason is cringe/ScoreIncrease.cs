using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ScoreIncrease : MonoBehaviour
{
    public GameObject scoretext;
    public Text scoreTrack;
    public static int score = 0;
    // Start is called before the first frame update
    public void Update()
    {
        score = 1;
        scoreTrack.text = score.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            scoreboard_red.Score += 100;
            GUIforScore.Score += 100;
        }
    }



}


