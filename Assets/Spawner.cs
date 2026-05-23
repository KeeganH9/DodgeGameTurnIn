using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public GameObject fallingObjectPrefab;
    float spawnInterval = 1f;
    float timer = 0f;
    void Start()
    {
        
    }
    void SpawnFallingObject()
    {
            float xPosition = Random.Range(-8f, 8f);
            Vector3 spawnPosition = new Vector3(xPosition, transform.position.y, transform.position.z);
            Instantiate(fallingObjectPrefab, spawnPosition, Quaternion.identity);
        }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnFallingObject();
            timer = 0f;
        }
    }
}
