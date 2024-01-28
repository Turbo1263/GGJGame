using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;


public class ScoreIncrease : MonoBehaviour
{
    public GameObject scoretext;
    private Text scoreTrack;
    private int scoreRed = 2;
    private int scoreBlue = 2;

    public void AddScoreBlue(int score)
    {
        scoreBlue += score;
    }
    public void AddScoreRed(int score)
    {
        scoreRed += score;
    }

    // Start is called before the first frame update
    public void LateUpdate()
    {
        scoretext.GetComponent<scoreboard_red>().SetScore(scoreRed);
        scoretext.GetComponent<GUIforScore>().SetScore(scoreBlue);
    }
}


