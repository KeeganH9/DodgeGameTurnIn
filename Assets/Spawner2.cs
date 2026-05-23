using UnityEngine;

public class Spawner2 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public GameObject FastFallObjectPrefab;
    float spawnInterval = 1.5f;
    float timer = 0f;
    void Start()
    {
        
    }
    void SpawnFastFallObject()
    {
            float xPosition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(xPosition, transform.position.y, transform.position.z);
            Instantiate(FastFallObjectPrefab, spawnPosition, Quaternion.identity);
        }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnFastFallObject();
            timer = 0f;
        }
    }
}
