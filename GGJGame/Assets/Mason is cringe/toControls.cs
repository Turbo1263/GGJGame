using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toControls : MonoBehaviour
{

    public void tomyControl()
    {
        SceneManager.LoadSceneAsync("Keybinds");
    }

}
