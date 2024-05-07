using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] private TMP_Text coinText;
    private int coinsCount;

    private void Start()
    {
        coinsCount = 0;
        coinText.text = "0";
    }
    private void OnEnable() {

        Coin.pickCoin.AddListener(IncreaseScore);
    }

    private void OnDisable() {
        Coin.pickCoin.RemoveListener(IncreaseScore);
    }

    public void IncreaseScore(){
        coinsCount++;
        coinText.text = coinsCount.ToString();
    }
}
