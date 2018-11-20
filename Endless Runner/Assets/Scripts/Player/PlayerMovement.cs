using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int jumpForce;
    public Rigidbody2D rb;
    public bool isGrounded;
    public int maxJumps;
    public int jumpsLeft;
    public int maxJumpTime;
    public int jumpTime = 0;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumpsLeft = maxJumps;
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Space) && jumpsLeft > 0)
        {
            rb.AddForce(Vector3.up * jumpForce);
            isGrounded = false;
            jumpsLeft = jumpsLeft - 1;
            Debug.Log("Jump");
        }
		if(Input.GetKey(KeyCode.Space) && jumpTime<maxJumpTime)
        {
            rb.AddForce(Vector3.up * 15);
            jumpTime = jumpTime + 1;
            Debug.Log(jumpTime);
        }
        if(rb.velocity.y < 0 && isGrounded == false)
        {
            rb.gravityScale = 3;
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.CompareTag("Floor"))
        {
            rb.gravityScale = 1;
            jumpsLeft = maxJumps;
            isGrounded = true;
            jumpTime = 0;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        rb.gravityScale = 1;
    }
}
