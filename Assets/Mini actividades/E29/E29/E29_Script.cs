using UnityEngine;

public class E29_RandomDrop : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private GameObject boxPrefab;
    [SerializeField] private float spawnHeight = 5f;
    [SerializeField] private float spawnRangeX = 8f;
    [SerializeField] private float spawnInterval = 2f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

       
        if (timer >= spawnInterval)
        {
            SpawnBox();
            timer = 0f;
        }
    }

    void SpawnBox()
    {
        
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 spawnPosition = new Vector3(randomX, spawnHeight, 0f);

        
        Instantiate(boxPrefab, spawnPosition, Quaternion.identity);
    }
}
