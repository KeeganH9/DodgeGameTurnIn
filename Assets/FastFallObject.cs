using UnityEngine;

public class FastFallObject : MonoBehaviour
{
    float fallspeed = 10f;
    float destroyY = -5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * fallspeed * Time.deltaTime;
        if (transform.position.y < destroyY)
        {
            Destroy(gameObject);
        } 
    }
}
