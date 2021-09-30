using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
   [SerializeField] float jumpSpeed;
   [SerializeField] float speed;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        MoveLeft();
        MoveRight();
        Jump();





    }

    void MoveRight()
    {

        if (ButtonController.goRight)
        {

            Debug.Log("sag");
           transform.Translate(Vector2.right*speed*Time.deltaTime);




        }

        
    }
    void MoveLeft()
    {

        if (ButtonController.goLeft)
        {
            transform.Translate(Vector2.left*speed*Time.deltaTime);
            Debug.Log("left");



        }


    }
    void Jump()
    {
        if (ButtonController.isJump)
        {
          rb.AddForce(Vector2.up*jumpSpeed);

        }
        Debug.Log("jump");




    }





}
