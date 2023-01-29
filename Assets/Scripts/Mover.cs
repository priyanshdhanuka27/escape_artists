using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Pretty good
public class Mover : MonoBehaviour
{
    [SerializeField] float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
       PrindInstruction(); 
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); 
    }

    void PrindInstruction()
    {
        Debug.Log ("Welcome to the Game");
        Debug.Log("Use Arrow Keys to move around");
        Debug.Log("Don't hit the Walls!");
    }
    
    void MovePlayer()
    {
        float xValue = Input.GetAxis("Vertical") * Time.deltaTime * movespeed * -1;
        float zValue = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        transform.Translate(xValue, 0, zValue);
    }

}


