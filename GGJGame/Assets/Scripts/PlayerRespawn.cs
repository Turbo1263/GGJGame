using System.Collections;
using System.Collections.Generic;
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

    // Update is called once per frame

}
