using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftPlatforme : MonoBehaviour
{
[SerializeField] private Transform firstPoint;
[SerializeField] private Transform secondPoint;
[SerializeField] private float Speed = 1.0f;
private Rigidbody2D rigidbody2D;
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
    rigidbody2D.position = Vector3.Lerp(firstPoint.position, secondPoint.position, Mathf.Ceil(Time.fixedTime) - Time.fixedTime);        
    }
}
