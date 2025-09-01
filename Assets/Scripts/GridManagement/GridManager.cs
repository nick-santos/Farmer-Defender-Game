using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{

    [SerializeField] Vector2Int gridSize;
    [SerializeField] int unityGridSize;
    public int UnityGridSize { get { return unityGridSize; } }

    Dictionary<Vector2Int, Node> grid = new Dictionary<Vector2Int, Node>();
    Dictionary<Vector2Int, Node> Grid { get { return grid; } }

    public string targetTag = "Tile";

    public Vector2Int tilePos;
    public Vector2Int tileMin = new Vector2Int(0,0);
    public Vector2Int tileMax = new Vector2Int(0,0);

    // private void Awake()
    // {
    //     for (int x = 0; x < gridSize.x; x++)
    //     {
    //         for (int y = 0; y < gridSize.y; y++)
    //         {
    //             Vector2Int cords = new Vector2Int(x, y);
    //             grid.Add(cords, new Node(cords));

    //             // GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    //             // Vector3 position = new Vector3(cords.x * unityGridSize, 0f, cords.y * unityGridSize);
    //             // cube.transform.position = position;
    //             // cube.transform.SetParent(transform);
    //         }
    //     }
    // }

    public void DefineTilesMinMax()
    {
        // Find all GameObjects with the specified tag
        GameObject[] taggedObjects = GameObject.FindGameObjectsWithTag(targetTag);

        // Loop through each GameObject in the array
        foreach (GameObject obj in taggedObjects)
        {
            tilePos = obj.GetComponent<Labeller>().cords;

            if (tilePos.x < tileMin.x)
            {
                tileMin.x = tilePos.x;
            }
            else if (tilePos.x > tileMax.x)
            {
                tileMax.x = tilePos.x;
            }
            if (tilePos.y < tileMin.y)
            {
                tileMin.y = tilePos.y;
            }
            else if (tilePos.y > tileMax.y)
            {
                tileMax.y = tilePos.y;
            }
        }
        //Debug.Log("Found Max X: " + tileMax.x + " | Y: " + tileMax.y);
        //Debug.Log("Found Min X: " + tileMin.x + " | Y: " + tileMin.y);
    }
}   
