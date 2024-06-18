using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrideMovement : MonoBehaviour
{
    public float Horizontal;
    public float Speed;
    public float JumpForce;
    public bool isFacingRight;
    public Animator anim;
    public Rigidbody2D rb;
    public Transform groundCheck;
    public LayerMask groundLayer;


    private bool canDash = true;
    private bool isDashing = false;
    public float dashingPower;
    public float dashingTime;
    public float dashingCooldown;
    public randowsounds bridesounds;
    void Start()
    {
        bridesounds = GetComponent<randowsounds>();
    }
    void Update()
    {
        if (isDashing)
        {
            return;
        }
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.J) && Isgrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpForce);
            bridesounds.jumpsound();
        }

        if (Input.GetKeyDown(KeyCode.J) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);


        }
        if (Input.GetKeyDown(KeyCode.Z) && canDash)
        {
            StartCoroutine(Dash());
        }


        if (Horizontal == 0)
        {

            anim.SetBool("isrunning", false);
        }
        else
        {
            anim.SetBool("isrunning", true);
        }
        if (isFacingRight && Horizontal < 0f)
        {
            Flip();
        }
        else if (!isFacingRight && Horizontal > 0f)
        {
            Flip();
        }

    }

    void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }

        rb.velocity = new Vector2(Horizontal * Speed, rb.velocity.y);
    }
   public bool Isgrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.4f, groundLayer);
    }

    void Flip()
    {

        isFacingRight = !isFacingRight;
        transform.Rotate(0, 180, 0);


    }
    private IEnumerator Dash()
    {
        canDash = false;
        isDashing = true;
        float originalGravity = rb.gravityScale;
        rb.gravityScale = 0f;
        rb.velocity = new Vector2(transform.localScale.x * dashingPower, 0f);
        // tr.emitting = true;
        yield return new WaitForSeconds(dashingTime);
        // tr.emitting = false;
        rb.gravityScale = originalGravity;
        isDashing = false;
        yield return new WaitForSeconds(dashingCooldown);
        canDash = true;
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(groundCheck.position, 0.4f);
    }
}
    