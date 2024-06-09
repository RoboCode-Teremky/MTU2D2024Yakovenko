using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOb : MonoBehaviour
{
[SerializeField] private Transform patrulePoint1,patrulePoint2;
[SerializeField] private float speed = 1.0f;
    void Start()
    {
        transform.position = Vector3.Lerp(patrulePoint1.position, patrulePoint2.position, Mathf.Sin(Time.fixedTime*speed)/2+0.5f);
    }


    void FixedUpdate()
    {
  
    }
}
