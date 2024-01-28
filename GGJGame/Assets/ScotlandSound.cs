using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScotlandSound : MonoBehaviour
{
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip --------")]
    public AudioClip Scotland;
    // Start is called before the first frame update
    public GameObject toggler;
    void Start()
    {
        print(toggler.GetComponent<Toggle>().isOn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void userInput(int direction)
    {
        print(direction);
    }
    public void userToggle(bool tog)
    {
        print(tog);
    }
    public void PlaySound()
    {
        musicSource.clip = Scotland;
        musicSource.Play();
    }
    
}
