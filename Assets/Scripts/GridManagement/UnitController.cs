using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitController : MonoBehaviour
{
    [SerializeField] float movementSpeed = 1f;

    Transform selectedUnit;
    bool unitSelected = false;

    GridManager gridManager;

    // Start is called before the first frame update
    void Start()
    {
        gridManager = FindObjectOfType<GridManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            bool hasHit = Physics.Raycast(ray, out hit);

            if (hasHit)
            {
                if (hit.transform.tag == "Tile")
                {
                    if (unitSelected)
                    {
                        Vector2Int targetCords = hit.transform.GetComponent<Labeller>().cords;
                        Vector2Int startCords = new Vector2Int((int)selectedUnit.position.x, (int)selectedUnit.position.y) / gridManager.UnityGridSize;

                        selectedUnit.transform.position = new Vector3(targetCords.x, selectedUnit.position.y, targetCords.y);
                        unitSelected = false;
                    }
                }
                if (hit.transform.tag == "Unit")
                {
                    selectedUnit = hit.transform;
                    unitSelected = true;
                }
            }
        }
    }
}
