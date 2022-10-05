using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int points = 1;
    [SerializeField] private List<AudioClip> clips;
     
    void OnTriggerEnter2D(Collider2D other)
    {
        var bird = other.GetComponent<Bird>();

        if(bird != null)
        {
            ScoreManager.AddPoints(points);

            int randomIndex = Random.Range(0, clips.Count);
            AudioClip clip = clips[randomIndex];
            GetComponent<AudioSource>().PlayOneShot(clip);

            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }

    public void ResetCoin()
    {
        GetComponent<Collider2D>().enabled = true;
        GetComponent<SpriteRenderer>().enabled = true;
    }
}
