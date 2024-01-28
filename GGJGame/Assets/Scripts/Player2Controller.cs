using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{
    [SerializeField]
    private float verticalLeft, horizontalLeft, verticalRight, horizontalRight;
    private float posX, posY, posZ;
    private float rotX, rotY, rotZ;
    [SerializeField]
    private float moveSpeed, rotSpeed;
    public bool buttonADown;
    [SerializeField]
    public GameObject scoreHandler;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Input.GetJoystickNames()[1] + "is moved");
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
        buttonADown = Input.GetButtonDown("Interact");
        verticalLeft = Input.GetAxis("VerticalLeft2");
        horizontalLeft = Input.GetAxis("HorizontalLeft2");
        verticalRight = Input.GetAxis("VerticalRight2");
        horizontalRight = Input.GetAxis("HorizontalRight2");
        //transform.position = new Vector3(posX + (moveSpeed * -horizontalLeft * Time.deltaTime), posY, posZ + (moveSpeed * verticalLeft * Time.deltaTime));
        transform.Translate(Vector3.forward * (moveSpeed) * Time.deltaTime * verticalLeft);
        transform.Rotate(new Vector3(0, rotY + (rotSpeed * horizontalRight * Time.deltaTime), 0));
    }
    private void Update()
    {

    }
}
