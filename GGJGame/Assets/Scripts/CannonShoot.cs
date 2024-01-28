using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject cannonBall;
    [SerializeField]
    private float cannonBallSpeed;
    [SerializeField]
    private Transform pof;
    [Header("-------- Audio Source --------")]
    [SerializeField] AudioSource musicSource;
    [Header("-------- Audio Clip --------")]
    public AudioClip Blast;

    IEnumerator Shoot()
    {
        GameObject ball = Instantiate(cannonBall, pof.position, Quaternion.identity);

        Rigidbody rb = ball.AddComponent<Rigidbody>();

        musicSource.clip = Blast;
        musicSource.Play();
        DontDestroyOnLoad(musicSource.clip);

        rb.velocity = cannonBallSpeed * pof.forward;
        rb.useGravity = false;

        yield return new WaitForSeconds(1f);

        StartCoroutine(Shoot());
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    
        

}
