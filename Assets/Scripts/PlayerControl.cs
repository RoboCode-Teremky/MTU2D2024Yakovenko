using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float jumpForce = 10.0f;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");

    Flip();

        foreach (RaycastHit2D raycastHit2D in Physics2D.RaycastAll(transform.position, Vector2.down, 1.5f))
        {
            if (raycastHit2D.collider.CompareTag("Ground") && Input.GetButton("Jump"))
            {
                rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                animator.SetTrigger("JumpT");
            }
        }

        rigidbody2D.velocity = new Vector2(moveX * speed, rigidbody2D.velocity.y);
        animator.SetFloat("SpeedX", Mathf.Abs(rigidbody2D.velocity.x));
        animator.SetFloat("SpeedY", rigidbody2D.velocity.y);
    }
    void Flip (){
        if (Input.GetAxis("Horizontal")<0){
            //transform.localRotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            spriteRenderer.flipX = true;
        }
        if (Input.GetAxis("Horizontal")>0){
            //transform.localRotation = Quaternion.Euler(0.0f, 180.0f, 0.0f);
            spriteRenderer.flipX = false;
        }


    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 1.5f);
    }

    private void OnTriggerStay2D (Collider2D other) {
        if (other.tag == "Ladder"){
            animator.SetBool ("Climb", true);
            rigidbody2D.velocity = Vector2.zero;
            rigidbody2D.AddForce(transform.up * jumpForce * 2.5f, ForceMode2D.Impulse);
        }

    }
    private void OnTriggerExit2D (Collider2D other){
        if(other.tag == "Ladder"){
            animator.SetBool("Climb", false);
        }
    }
}
