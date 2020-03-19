using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPickup : MonoBehaviour
{
    public int color;
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D other)
    {
        player.GetComponent<Shape>().changeColor(color);
        Debug.Log("pickup");
    }
}
