using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

public class GameGrid : MonoBehaviour
{
     private int height = 10;
     private int width = 10;
    
     private float gridSpaceSize = 1.25f;
     
     private GameObject[,] gameGrid;
     [SerializeField]private GameObject gameGridPrefab;
     
    // Start is called before the first frame update
    void Start()
    {
        CreateGrid();
    }

    //CREATES GRID 
    private void CreateGrid()
    {
        gameGrid = new GameObject[height, width];

        if (gameGridPrefab == null)
        {
            Debug.LogError("NO PREFAB SELECTED TO INSTANTIATE");
        }
        
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                gameGrid[i, j] = Instantiate(gameGridPrefab, new Vector3(i * gridSpaceSize, j * gridSpaceSize), Quaternion.identity);
                gameGrid[i, j].transform.parent = transform;
                //SET POSITION
                gameGrid[i, j].GetComponent<GridCell>().SetPosition(i+1, j+1);
                gameGrid[i, j].gameObject.name = "Grid Spaced (X:" + i.ToString() + "Y: " + j.ToString() + " )";
            }
        }
    }

}
