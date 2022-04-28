/**** 
 * Created by: Bob Baloney
 * Date Created: April 20, 2022
 * 
 * Last Edited by: Kyunghoon Han
 * Last Edited: April 28, 2022
 * 
 * Description: Controls the ball and sets up the intial game behaviors. 
****/

/*** Using Namespaces ***/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed; // speed constant
    public int score; // score
    public int ballLives; // number of balls
    Paddle refPad; // GameObject paddle reference
    public bool isInPlay; // true or false
    Rigidbody rb;
    AudioSource audioSource;
    Vector3 initalForce;

 //   [Header("General Settings")]


 //   [Header("Ball Settings")]
   


 


    //Awake is called when the game loads (before Start).  Awake only once during the lifetime of the script instance.
    void Awake()
    {
        
    }//end Awake()


    // Start is called before the first frame update
    void Start()
    {
        SetStartingPos(); //set the starting position

    }//end Start()


    // Update is called once per frame
    void Update()
    {
        // checks the text property of the ballTxt and scoreTxt to update with values

        // check if ball not in play
        if (isInPlay == false)
        {
            
        }

        // check if Space key is pressed and if ball not is in play
        if (isInPlay == false)
        {
            isInPlay = true;
            
        }
    }//end Update()


    private void LateUpdate()
    {
        if (isInPlay == true)
        {
            // Like this but the speed * velocity.normalized is more complicated
          //  Vector3 velocity = speed * velocity.normalized;
        }

    }//end LateUpdate()


    void SetStartingPos()
    {
        isInPlay = false;//ball is not in play
        rb.velocity = Vector3.zero;//set velocity to keep ball stationary

        Vector3 pos = new Vector3();
    //    pos.x = paddle.transform.position.x; //x position of paddel
    //    pos.y = paddle.transform.position.y + paddle.transform.localScale.y; //Y position of paddle plus it's height

        transform.position = pos;//set starting position of the ball 
    }//end SetStartingPos()


    void move()
    {
        // AddForce to Rigidbody using the initalForce value
       // Vector3 AddForce = Rigidbody(initalForce);
    }

    void OnCollisionEnter()
    {
       if (tag == "Brick")
        {
            score += 100;
            // object.destory();
        }
    }

    void OnTriggerEnter()
    {
        if (tag == "OutBounds")
        {
            ballLives--;
            if (ballLives < 0)
            {
                //Invoke(SetStaringPosition, 2); not like this
            }
        }
    }

}
