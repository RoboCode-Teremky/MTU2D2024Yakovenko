using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 1.0f;
    [SerializeField] private float jumpForce = 10.0f;
    private Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");

        foreach (RaycastHit2D raycastHit2D in Physics2D.RaycastAll(transform.position, Vector2.down, 1.5f))
        {
            if (raycastHit2D.collider.CompareTag("Ground") && Input.GetButton("Jump"))
            {
                rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
        }

        rigidbody2D.velocity = new Vector2(moveX * speed, rigidbody2D.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + Vector3.down * 1.5f);
    }
}
