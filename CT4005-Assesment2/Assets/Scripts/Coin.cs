using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField]
    float CoinRotateSpeed = 0.5f;
    [SerializeField]
    float CoinValue = 1f;

    void Update()
    {
        this.gameObject.transform.Rotate(0, CoinRotateSpeed, 0);


    }
}
