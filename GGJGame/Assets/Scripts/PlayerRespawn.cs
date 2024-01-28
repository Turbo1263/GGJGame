using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField]
    private GameObject respawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = respawnPoint.transform.position;
    }
    void Update()
    {
       if(Input.GetButtonDown("Reset1") && this.name == "Player")
        {
            transform.position = respawnPoint.transform.position;
            transform.rotation = respawnPoint.transform.rotation;
        }
        if (Input.GetButtonDown("Reset2") && this.name == "Player2")
        {
            transform.position = respawnPoint.transform.position;
            transform.rotation = respawnPoint.transform.rotation;
        }
    }

    // Update is called once per frame

}
