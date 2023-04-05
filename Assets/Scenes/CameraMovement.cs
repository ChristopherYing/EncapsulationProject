using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Rigidbody2D player;

    void LateUpdate()
    {
        transform.position = new Vector3(player.position.x, player.position.y + 1, transform.position.z);
    }
}
