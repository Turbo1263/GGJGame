using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeGems : MonoBehaviour
{
    private GameObject ObjectIWantToPickUp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gem") 
        {
            ObjectIWantToPickUp = other.gameObject;
            ObjectIWantToPickUp.transform.position = transform.position + new Vector3(0, 1, 0); // sets the position of the object to your hand position
            ObjectIWantToPickUp.transform.parent = transform;
            Debug.Log("PickedUpGem");

        }
    }
    void Update()
    {
        
    }
}
