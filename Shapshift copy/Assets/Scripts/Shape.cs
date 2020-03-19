using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public int colorPlayer;
    public int shapePlayer;
    private int[] activated = {
        1, 1, 0, 0, 0, 0
    };

    private SpriteRenderer sr;

    public Sprite[] green;
    public Sprite[] blue;
    public Sprite[] yellow;
    public Sprite[] pink;

    private Sprite[] currentColor;

    public ShapesManager sm;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        changeColor(colorPlayer);
        sr.sprite = currentColor[shapePlayer];
    }

    public void addShape(int s)
    {
        activated[s] = 1;
        sm.setShapeActive(s);
    }

    public void changeColor(int c)
    {
        if (c == 0)
        {
            currentColor = green;
            colorPlayer = 0;
        } else if (c == 1)
        {
            currentColor = yellow;
            colorPlayer = 1;
        } else if (c == 2)
        {
            currentColor = blue;
            colorPlayer = 2;
        } else if (c == 3)
        {
            currentColor = pink;
            colorPlayer = 3;
        }
        sr.sprite = currentColor[shapePlayer];
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && activated[1] == 1)
        {
            shapePlayer = 1;
            sr.sprite = currentColor[1];
            Invoke("becomeBlob", 2);
            sm.setShapeUsing(1);
        }
        if (Input.GetKeyDown("2") && activated[2] == 1)
        {
            shapePlayer = 2;
            sr.sprite = currentColor[2];
            Invoke("becomeBlob", 2);
            sm.setShapeUsing(2);
        }
        if (Input.GetKeyDown("3") && activated[3] == 1)
        {
            shapePlayer = 3;
            sr.sprite = currentColor[3];
            Invoke("becomeBlob", 2);
            sm.setShapeUsing(3);
        }
        if (Input.GetKeyDown("4") && activated[4] == 1)
        {
            shapePlayer = 4;
            sr.sprite = currentColor[4];
            Invoke("becomeBlob", 2);
            sm.setShapeUsing(4);
        }
        if (Input.GetKeyDown("5") && activated[5] == 1)
        {
            shapePlayer = 5;
            sr.sprite = currentColor[5];
            Invoke("becomeBlob", 2);
            sm.setShapeUsing(5);
        }
    }

    void becomeBlob()
    {
        shapePlayer = 0;
        sr.sprite = currentColor[0];
    }
}
