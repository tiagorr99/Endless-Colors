﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectorScript : MonoBehaviour
{

    private int coinCounter = 0;
    public Canvas coinCanvas;

    // Start is called before the first frame update
    void Start()
    {
        coinCanvas.GetComponentInChildren<Text>().text = coinCounter.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        coinCanvas.GetComponentInChildren<Text>().text = coinCounter.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCounter++;
            Debug.Log("More coins! " + coinCounter);
        }
    }
}
