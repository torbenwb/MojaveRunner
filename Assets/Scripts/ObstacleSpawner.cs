using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;

    public float timeToSpawn;
    public float timeToSpawnMin;
    public float timeToSpawnMax;

    // Start is called before the first frame update
    void Start()
    {
        timeToSpawn = Random.Range(timeToSpawnMin, timeToSpawnMax);
    }

    // Update is called once per frame
    void Update()
    {
        timeToSpawn -= Time.deltaTime;

        if (timeToSpawn <= 0.0f)
        {
            SpawnObstacle();
            timeToSpawn = Random.Range(1f,2f);
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obstaclePrefabs[Random.Range(0,obstaclePrefabs.Length)], 
        transform.position, Quaternion.identity);
    }
}
