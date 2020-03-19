using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ShapePickup : MonoBehaviour
{
    public int shape;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.GetComponent<Shape>().addShape(shape);
        Destroy(gameObject);
    }
}
