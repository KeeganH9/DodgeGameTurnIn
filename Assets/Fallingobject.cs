using UnityEngine;

public class Fallingobject : MonoBehaviour
{
    float fallspeed = 5f;
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
