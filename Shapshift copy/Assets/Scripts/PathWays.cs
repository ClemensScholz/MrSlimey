using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathWays : MonoBehaviour
{
    public GameObject player;

    public int color;
    public int shape;

    private Shape shapeClass;
    
    // Start is called before the first frame update
    void Start()
    {
        shapeClass = player.GetComponent<Shape>();
    }

    // Update is called once per frame
    void Update()
    {
        if (shape == shapeClass.shapePlayer && color == shapeClass.colorPlayer)
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), true);   
        }
        else
        {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>(), false);
        }
    }
}
