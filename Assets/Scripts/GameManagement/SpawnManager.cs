using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    //private float spawnRangeX = 10;
    private float spawnPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 2f;

    GridManager gridManager;
    int tileSize;
    Vector2Int tileMax, tileMin;

    public void SetupSpawner()
    {
        gridManager = FindObjectOfType<GridManager>();
        tileSize = gridManager.UnityGridSize;
        tileMin = gridManager.tileMin;
        tileMax = gridManager.tileMax;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        float spawnPosX = Random.Range(tileMin.x, tileMax.x + 1) * tileSize;
        // Debug.Log(spawnPosX);
        //Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Vector3 spawnPos = new Vector3(spawnPosX, 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
