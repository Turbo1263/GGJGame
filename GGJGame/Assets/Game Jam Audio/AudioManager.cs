
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{

    [SerializeField] Slider volumeSlider;

    [SerializeField]
    private GameObject self;

    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("-------- Audio Clip --------")]
    public AudioClip MenuMusic;
    public AudioClip StartButtonSound;
    public AudioClip ButtonClick;



    public AudioClip OptionsMusic;
    public AudioClip InGameMusic1;
    public AudioClip SCOTLAND_FOREVER;

    private string currentScene;
    private string oldScene;
    private bool sceneChanged;


    IEnumerator Waiter() 
    {
        yield return new WaitForSeconds(.2f);
    }    

    private void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        if (sceneName == "Main Menu")
        {
            musicSource.clip = MenuMusic;
            musicSource.Play();
        }
        else if (sceneName == "OptionScene")
        {
     
            musicSource.clip = OptionsMusic;
            musicSource.Play();
        }
        else if (sceneName == "Loading_funni_1")
        {
            
            musicSource.clip = InGameMusic1;
            musicSource.Play();
        }
    }
    private void LateUpdate()
    {
        currentScene = GetCurrentScene();
        sceneChanged = IsNewScene(currentScene, oldScene);
        if (sceneChanged) { Scene_Music(currentScene); }
        oldScene = currentScene;
        Debug.Log(currentScene);

    }
    private string GetCurrentScene() 
    {
        Scene currentScene = SceneManager.GetActiveScene();

        string sceneName = currentScene.name;
        return sceneName;
    }
    private bool IsNewScene(string currentScene, string oldScene)
    {
        if (currentScene != oldScene) { return true; }
        else { return false; }
    } 
    private void Scene_Music(string sceneName)
    {
        StartCoroutine(Waiter());
        if (sceneName == "Main Menu")
        {
            musicSource.clip = MenuMusic;
            musicSource.Play();
        }
        else if (sceneName == "OptionScene")
        {
            Debug.Log(sceneName);
            musicSource.clip = OptionsMusic;
            musicSource.Play();
        }
        else if (sceneName == "Loading_funni_1")
        {

            musicSource.clip = InGameMusic1;
            musicSource.Play();
        }
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

