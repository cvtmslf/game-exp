using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollowPlayer : MonoBehaviour
{
    public Transform player;
    public float smoothing;
    public Vector3 offset;

    void FixedUpdate()
    {
        if (player != null)
        { 
            transform.position = player.position + offset; 
        }


    }



}
