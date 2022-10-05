using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    [SerializeField] float speed = 3;
    [SerializeField] float jumpVelocity = 1;

    [Range(1f, 1.5f)]
    [SerializeField] float burstJumpVelocity = 1.5f;

    [SerializeField] float upRotation;
    [SerializeField] float downRotation;
    
    Rigidbody2D rb;
    Vector3 birdZRotarion = Vector3.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (Input.GetButtonDown("Fire1"))
        {
            if(rb.velocity.y < 0)
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpVelocity * burstJumpVelocity);
            }
            else
            {
                rb.velocity = new Vector2(rb.velocity.x, jumpVelocity);
            }

        }

        BirdRotation();
    }

    private void BirdRotation()
    {
        float degrees = 0;

        if (rb.velocity.y > 0)
        {
            degrees = 6 * upRotation;
        }
        else
        {
            degrees = -3 * downRotation;
        }

        birdZRotarion = new Vector3(0, 0, Mathf.Clamp(birdZRotarion.z + degrees, -90, 45));
        transform.eulerAngles = birdZRotarion;
    }
}
