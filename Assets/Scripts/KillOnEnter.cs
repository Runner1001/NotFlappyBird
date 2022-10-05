using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillOnEnter : MonoBehaviour
{
    [SerializeField] Canvas gameOverCanvas;

    void OnCollisionEnter2D(Collision2D other)
    {
        var bird = other.collider.GetComponent<Bird>();

        if(bird != null)
        {
            bird.gameObject.SetActive(false);
            gameOverCanvas.gameObject.SetActive(true);
        }
    }
}
