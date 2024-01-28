using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class TakeGems : MonoBehaviour
{
    private GameObject objectIWantToPickUp;
    private bool canPickUp;
    private bool canDrop;
    private bool gemTaken;
    [SerializeField] private GameObject self;
    private GameObject dropTarget;


    public bool GetGemTaken() { return gemTaken; }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Gem") 
        {
            canPickUp = true;
            objectIWantToPickUp = other.gameObject;
        }
        if(other.gameObject.tag == "CartGoal")
        {
            canDrop = true;
            dropTarget = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Gem")
        {
            canPickUp = false;
            //objectIWantToPickUp = null;
        }
        if (other.gameObject.tag == "CartGoal") 
        {
            canDrop = false;
            dropTarget = null;
        }
        
    }
    private void PickUp()
    {
        gemTaken = true;
        objectIWantToPickUp.transform.position = transform.position + new Vector3(0, 1, 0); // sets the position of the object to your hand position
        objectIWantToPickUp.transform.parent = transform;
        Debug.Log("PickedUpGem");
    }
    private void DropGems()
    {   //Destroys Gem & Clears var value
        if(self.name == "Player2")
        {
           self.GetComponent<Player2Controller>().scoreHandler.GetComponent<ScoreIncrease>().AddScoreBlue(1);
        }
        if (self.name == "Player")
        {
            self.GetComponent<CharacterMoveController>().scoreHandler.GetComponent<ScoreIncrease>().AddScoreRed(1);
        }
        Destroy(objectIWantToPickUp); 
        objectIWantToPickUp = null;
    }
    private void Update()
    {
        if (canPickUp)
        {
            if (self.name == "Player2" && self.GetComponent<Player2Controller>().buttonADown)
            {
                PickUp();
            }
            if (self.name == "Player" && self.GetComponent<CharacterMoveController>().buttonADown)
            {
                PickUp();
            }
        }
        if (canDrop)
        {
            if (self.name == "Player2" && self.GetComponent<Player2Controller>().buttonADown)
            {
                DropGems();
            }
            if (self.name == "Player" && self.GetComponent<CharacterMoveController>().buttonADown)
            {
                DropGems();
            }
        }

    }
}
