using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;

public class ScotlandToggle : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [Header("-------- Audio Clip --------")]
    public AudioClip SCOTLAND_FOREVER;
    public AudioClip OptionsMusic;
    // Start is called before the first frame update
    void Start()
    {
        musicSource.clip = SCOTLAND_FOREVER;
        musicSource.Play();
    }
    public void Scotland()
    {
        musicSource.clip = SCOTLAND_FOREVER;
        musicSource.Play();
    }

}
