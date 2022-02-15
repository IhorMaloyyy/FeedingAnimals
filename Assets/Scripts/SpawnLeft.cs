using UnityEngine;

public class SpawnLeft : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 23;
    private float spawnRangeZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAmimalRight", startDelay, spawnInterval);
    }
    void SpawnRandomAmimalRight()
    {
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(-12, spawnRangeZ));
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
