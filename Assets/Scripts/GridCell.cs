using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class GridCell : MonoBehaviour
{
    private int posX;
    private int posY;
    
    public void SetPosition(int x, int y)
    {
        posX = y;
        posY = x;
    }

    public Vector2Int GetPosition()
    {
        return new Vector2Int(posX, posY);
    }

    private void OnMouseDown()
    {   
        // Debug.Log("ROW: " + posY + "COLUMN: " + posX);
    }
}
