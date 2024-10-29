using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnbozo : MonoBehaviour
{
    public void retbozo()
    {
        SceneManager.LoadSceneAsync("Keybinds");
    }

}
