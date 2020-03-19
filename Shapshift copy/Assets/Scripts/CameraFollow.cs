using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTank;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(playerTank.position.x, playerTank.position.y, transform.position.z);
    }
}
