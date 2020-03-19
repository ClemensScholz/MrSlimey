using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quotes : MonoBehaviour
{
    private SpriteRenderer sr;
    private int current = 0;

    public Sprite[] quotes;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        NextQuote();
    }

    void NextQuote()
    {
        current++;
        if (current >= quotes.Length)
        {
            current = 0;
        }

        sr.sprite = quotes[current];
        
        Invoke("NextQuote", 5);
    }
}
