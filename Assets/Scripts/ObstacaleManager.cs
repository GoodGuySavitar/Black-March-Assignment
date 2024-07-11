using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacaleManager : MonoBehaviour
{
    private InputManager inputManager;

    [SerializeField] private GameObject redSpherePrefab;
    // Start is called before the first frame update
    void Start()
    {
        inputManager = FindObjectOfType<InputManager>();
    }

    // Update is called once per frame
    void Update()
    {
        GridCell cell = inputManager.IsMouseOverAGridSpace();
        if (inputManager.isOccupied)
        {
            Instantiate(redSpherePrefab, 
                new Vector3(cell.transform.position.x - 0.5f ,cell.transform.position.y,cell.transform.position.z),
                transform.rotation);
            inputManager.isOccupied = false;
        }
    }
}
