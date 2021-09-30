using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public static bool isJump, goRight, goLeft;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void RightDown()
    {
        goRight = true;


    }
   public  void RightUp()
    {
        goRight = false;


    }

   public  void LeftDown()
    {
        goLeft = true;


    }

   public  void LeftUp()
    {
        goLeft = false;


    }
  public  void JumpDown()
    {

        isJump = true;

    }
    public void JumpUp()
    {

        isJump = false;

    }









}
