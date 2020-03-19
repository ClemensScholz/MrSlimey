using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapesManager : MonoBehaviour
{
    public UIShape[] shapesUI;
    // Start is called before the first frame update
    
    public void setShapeActive(int i) {
        shapesUI[i - 1].setActive();
    }

    public void setShapeUsing(int i)
    {
        shapesUI[i - 1].setUsing();
    }
}
