using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage=1;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.TryGetComponent<PlayerInteraction>(out PlayerInteraction pi)){
            pi.TakeDamage(damage);
        }
    }
}
