using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    GridManager gridManager;
    SpawnManager spawnManager;

    // Start is called before the first frame update
    void Start()
    {
        gridManager = FindObjectOfType<GridManager>();
        spawnManager = FindObjectOfType<SpawnManager>();
        gridManager.GetComponent<GridManager>().DefineTilesMinMax();
        spawnManager.GetComponent<SpawnManager>().SetupSpawner();
    }


}
