using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    bool isJumping;
    public float jumpForce;
    public float moveSpeed;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            int theTouches = Input.touchCount;
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if (touch.phase == TouchPhase.Began)
            {
                print(theTouches + " touch(es) detected");
                print("touchPosition: " + touchPosition);
                
                if (touchPosition.x > 0) 
                    rb.velocity = new Vector2(moveSpeed, jumpForce);
                else if (touchPosition.x <= 0)
                    rb.velocity = new Vector2(-moveSpeed, jumpForce);

                //rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

                //To be removed
                if(transform.position.y > 1.5)
                {
                    GetComponent<Rigidbody2D>().gravityScale = 0;
                    Debug.Log("Gravitation Disabled");
                    rb.velocity = new Vector2(0, 0);
                    rb.velocity = new Vector2(0, 0);
                }
            }

            //if (touch.phase == TouchPhase.Moved)
        }
    }
}
