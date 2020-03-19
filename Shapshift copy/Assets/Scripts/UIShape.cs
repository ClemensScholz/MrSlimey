using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIShape : MonoBehaviour
{
    public Sprite[] states;
    public bool active;

    private void Start()
    {
        GetComponent<Image>().sprite = states[0];
        if (active)
        {
            setActive();
        }
    }

    public void setActive()
    {
        GetComponent<Image>().sprite = states[1];
    }

    public void setUsing()
    {
        GetComponent<Image>().sprite = states[2];
        Invoke("setActive", 2);
    }
}
