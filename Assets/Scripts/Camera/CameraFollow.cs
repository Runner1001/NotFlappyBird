using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] Transform playerToFollow;

    void LateUpdate()
    {
        transform.position = new Vector3(playerToFollow.position.x, transform.position.y, transform.position.z);
    }
}
