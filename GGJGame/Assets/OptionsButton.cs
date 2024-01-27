using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsButton : MonoBehaviour
{
    public void goTosetting()
    {
        SceneManager.LoadSceneAsync("OptionScene");
    }
}
