using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Coin : MonoBehaviour
{
    public static UnityEvent pickCoin = new UnityEvent();
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player")){
            pickCoin.Invoke();
            Destroy(gameObject);
        }
    }
}
