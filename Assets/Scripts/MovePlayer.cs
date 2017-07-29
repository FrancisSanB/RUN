using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    [HideInInspector] public bool facingRight = true;
    [HideInInspector] public bool jump = false;
    public float moveForce = 365f;
    public float maxSpeed = 5f;
    public float jumpForce = 1000f;
    public Transform groundCheck;

    private bool grounded = false;
    private Animator anim;

    Rigidbody2D playerRigidbody;

    bool moveLeft;
    bool moveRight;
    
    void Start()
    {
        Application.targetFrameRate = 60;
        anim = GetComponent <Animator>();
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        anim.SetBool("Grounded", grounded);
        if (Input.GetButtonDown("Jump") && grounded)
        {
            jump = true;
        }

    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        anim.SetFloat("Speed", Mathf.Abs(h));

        if (h * playerRigidbody.velocity.x < maxSpeed)
            playerRigidbody.AddForce(Vector2.right * h * moveForce);

        if (Mathf.Abs(playerRigidbody.velocity.x) > maxSpeed)
            playerRigidbody.velocity = new Vector2(Mathf.Sign(playerRigidbody.velocity.x) * maxSpeed, playerRigidbody.velocity.y);

        if (h > 0 && !facingRight)
            Flip();
        else if (h < 0 && facingRight)
            Flip();

        if (jump)
        {
            anim.SetTrigger("Jump");
            playerRigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
            jump = false;
        }
    }


    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
