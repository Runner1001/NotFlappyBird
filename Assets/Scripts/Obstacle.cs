using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    //[SerializeField] float moveSpeed = 1;
    Camera mainCam;

    private Coin coin;
    private float startYPosition;

    void Start()
    {
        mainCam = FindObjectOfType<Camera>();
        coin = GetComponentInChildren<Coin>();
        startYPosition = UnityEngine.Random.Range(-2, 2);
        transform.position = new Vector3(transform.position.x, startYPosition, 0);
    }

    void Update()
    {
        //transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        if(transform.position.x <= mainCam.transform.position.x - 10)
        {
            ResetObstacle();
        }
    }

    private void ResetObstacle()
    {
        transform.position += Vector3.right * 21f;

        float newY = UnityEngine.Random.Range(-2f, 2f);
        transform.position = new Vector3 (transform.position.x, newY, 0);

        coin.ResetCoin();
    }
}
