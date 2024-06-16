using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladders : MonoBehaviour
{
private float inputVertical;
private float speed;
Rigidbody2D rb;
private float distance;
private bool Climbing;
private LayerMask whatisLadder;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        
    }
}
