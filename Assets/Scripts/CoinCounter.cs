using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode]

public class CoinCounter : MonoBehaviour
{
    public static int coinValue;
    public Text scoreText;

    void Start ()
    {
        coinValue = 0;
    }

    void Update ()
    {
        scoreText.text = coinValue.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coinValue = coinValue + 1;
        }
    }
}