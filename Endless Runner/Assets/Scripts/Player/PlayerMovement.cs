using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public int jumpForce;
    public Rigidbody2D rb;
    private bool isGrounded;
    public int maxJumps;
    private int jumpsLeft;
    public GameObject gm;
    private bool jump;
    public float maxFallMultiplier;
    private bool jumpEnded;

	// Use this for initialization
	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        jumpsLeft = maxJumps;
        gm = GameObject.FindGameObjectWithTag("GM");
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.touchCount > 0)
        //{
           // Touch touch = Input.GetTouch(0);

        if (Input.GetButtonDown("Jump") && jumpsLeft > 0)
            {
                rb.AddForce(Vector2.up * jumpForce,ForceMode2D.Impulse);
                jumpsLeft -= 1;
            }
            if(Input.GetButtonUp("Jump") && rb.velocity.y > 0)
            {
                rb.AddForce(Vector2.down * rb.velocity.y / 2, ForceMode2D.Impulse);
            }
            rb.gravityScale = 1 - rb.velocity.y * maxFallMultiplier;
        //}
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.gameObject.CompareTag("Floor"))
        {
            jumpsLeft = maxJumps;
            isGrounded = true;
        }

        if (collision.collider.gameObject.transform.CompareTag("Wall"))
        {
            Debug.Log("HIT!!!");
            gm.GetComponent<UIHandler>().Death();
        }

    }
}
