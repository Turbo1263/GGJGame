using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMoveController : MonoBehaviour
{
    [SerializeField]
    private float verticalLeft, horizontalLeft, verticalRight, horizontalRight;
    private float posX, posY, posZ;
    private float rotX, rotY, rotZ;
    [SerializeField]
    private float moveSpeed, rotSpeed;
    public bool buttonADown;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Input.GetJoystickNames()[0] + "is moved");
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        if (posY <= 0.5f)
        {
            transform.position = new Vector3(posX, 0.74f, posZ);
        }
    }
    void FixedUpdate()
    {
        buttonADown = Input.GetButtonDown ("Interact");
        verticalLeft = Input.GetAxis("VerticalLeft1");
        horizontalLeft = Input.GetAxis("HorizontalLeft1");
        verticalRight = Input.GetAxis("VerticalRight1");
        horizontalRight = Input.GetAxis("HorizontalRight1");
        transform.position = new Vector3(posX + (moveSpeed * -horizontalLeft * Time.deltaTime), posY, posZ + (moveSpeed * verticalLeft * Time.deltaTime));
        transform.Rotate(new Vector3(0, rotY + (rotSpeed * horizontalRight * Time.deltaTime), 0));

    }
}
