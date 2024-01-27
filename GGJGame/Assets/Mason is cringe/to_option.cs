using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class to_option : MonoBehaviour
{
    public void toControl()
    {
        SceneManager.LoadSceneAsync("OptionScene");
    }

}
