using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private GameGrid gameGrid;
    
    [SerializeField] private LayerMask GridLayer;

    [SerializeField] private TextMeshProUGUI gridUnits;

    public bool isOccupied;
    // Start is called before the first frame update
    void Start()
    {
        gameGrid = FindObjectOfType<GameGrid>();
    }

    // Update is called once per frame
    void Update()
    {
        GridCell cell = IsMouseOverAGridSpace();
        if (cell != null)
        {
            gridUnits.text = "Cell Position(r,c): " + cell.GetPosition();
            if (Input.GetMouseButtonDown(0))
            {
                isOccupied = true;
            }
        }
    }
    
    //SHOOTING RAYS FROM THE CAMERA TO CHECK IF MOUSE IS HOVERING OVER THE GRID
    public GridCell IsMouseOverAGridSpace()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f, GridLayer))
        {
            return hitInfo.transform.GetComponent<GridCell>();
        }
        else
        {
            return null;
        }
    }
}
