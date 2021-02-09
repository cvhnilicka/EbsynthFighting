using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MovementController : MonoBehaviour
{

    // config
    [Header("Config")]
    [SerializeField] float runSpeed = 10.0f;
    [SerializeField] float jumpSpeed = 5.0f;

    // cached componenets
    [Header("Components")]
    Rigidbody2D myBody;
    Animator myAnimator;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        Walk();
        Jump();

        
        
    }

    void Walk()
    {
        float controlThrow = CrossPlatformInputManager.GetAxis("Horizontal");
        FlipSprite(controlThrow);
        WalkAnimation(controlThrow);

        Vector2 playerVelocity = new Vector2(controlThrow * runSpeed, myBody.velocity.y);
        myBody.velocity = playerVelocity;
    }


    void Jump()
    {
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            Vector2 jumpVelocity = new Vector2(0f, jumpSpeed);
            myBody.velocity += jumpVelocity;
            myAnimator.SetTrigger("Jump");

        }
    }


    void WalkAnimation(float controlthrow)
    {
        if (Mathf.Abs(controlthrow) > 0.0f)
        {
            Debug.Log("IS WALKING");
            myAnimator.SetBool("IsWalking", true);
        }
        else
        {
            if (myAnimator.GetBool("IsWalking")) myAnimator.SetBool("IsWalking", false);

        }
    }


    private void FlipSprite(float controlthrow)
    {
        Debug.Log("ControlThrow: " + controlthrow);
        if (controlthrow < 0)
        {
            transform.localScale = new Vector2(-(Mathf.Abs(transform.localScale.x)), transform.localScale.y);
        }
        else if (controlthrow > 0)
        {
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x), transform.localScale.y);
        }
    }


}
