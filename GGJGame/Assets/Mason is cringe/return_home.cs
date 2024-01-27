using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class return_home : MonoBehaviour
{
    public void toMenu()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
    public void escHit()
    {
        if (UnityEngine.Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadSceneAsync("Main Menu");
        }
    }
}
