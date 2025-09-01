using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{

    [SerializeField] private Camera mainCamera; 

    public GameObject Cylinder;
    public GameObject Seed;

    GridManager gridManager;
    int tileSize;

    // Start is called before the first frame update
    void Start()
    {
        gridManager = FindObjectOfType<GridManager>();
        tileSize = gridManager.UnityGridSize;
    }

    // Update is called once per frame
    private void Update()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        bool hasHit = Physics.Raycast(ray, out hit);

        if (hasHit)
        {
            if (hit.transform.tag == "Tile")
            {
                Vector2Int targetCords = hit.transform.GetComponent<Labeller>().cords;
                transform.position = new Vector3(targetCords.x * tileSize, transform.position.y, targetCords.y * tileSize);
            }

            //transform.position = hit.point;
            }
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Seed, transform.position, Seed.transform.rotation);
        }
    }
}
