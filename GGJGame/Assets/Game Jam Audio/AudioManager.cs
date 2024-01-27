using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;
    private GameObject self;

    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip --------")]
    public AudioClip MenuMusic;
    public AudioClip StartButtonSound;
    public AudioClip ButtonClick;

    private void Start()
    {
        musicSource.clip = MenuMusic;
        musicSource.Play();
        
    }
    public void Start_Button()
    {
        DontDestroyOnLoad(self);
        musicSource.clip = StartButtonSound;
        musicSource.loop = false;
        musicSource.Play();
    }
    public void Options_Button()
    {
        DontDestroyOnLoad(self);
        musicSource.clip = ButtonClick;
        musicSource.loop = false;
        musicSource.Play();
    }

    public void changeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }

}

