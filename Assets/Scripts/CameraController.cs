using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{    
    public Transform player, wall;
    public float speed = 1f;
    public Vector3 offset;
    public static bool isHeFinished = false;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + offset, speed * Time.deltaTime);        
        transform.LookAt(isHeFinished ? wall : player);
    }
}
