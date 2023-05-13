using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVeloctiy;
    private bool IsGrouded;
    public float speed = 5f;
    public float gravity = -9.8f;
    public float jumpHeight = 3f;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        IsGrouded = controller.isGrounded;
    }
    public void ProcessMove(Vector2 input) 
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = input.x;
        moveDirection.z = input.y;
        controller.Move(transform.TransformDirection(moveDirection)* speed * Time.deltaTime);
        playerVeloctiy.y += gravity * Time.deltaTime;
        if(IsGrouded && playerVeloctiy.y < 0)
            playerVeloctiy.y = -2f;
        controller.Move(playerVeloctiy * Time.deltaTime);
        Debug.Log(playerVeloctiy.y);
    }

    public void Jump()
    {
        if(IsGrouded)
        {
          playerVeloctiy.y = Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }
    }
}
