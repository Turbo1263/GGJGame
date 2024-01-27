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


    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
    }
    void FixedUpdate()
    {
        verticalLeft = Input.GetAxis("VerticalLeft");
        horizontalLeft = Input.GetAxis("HorizontalLeft");
        verticalRight = Input.GetAxis("VerticalRight");
        horizontalRight = Input.GetAxis("HorizontalRight");
        transform.position = new Vector3(posX + (moveSpeed * -horizontalLeft * Time.deltaTime), posY, posZ + (moveSpeed * verticalLeft * Time.deltaTime));
        transform.Rotate(new Vector3(0, rotY + (rotSpeed * horizontalRight * Time.deltaTime), 0));

    }
}
