using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput = 0f;
    float movementSpeed = 5f;
    float xlimit=8f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            horizontalInput = -1f;
        }
        else if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            horizontalInput = 1f;
        }
        else
        {
            horizontalInput = 0f;
        }
        transform.position += Vector3.right * horizontalInput * movementSpeed * Time.deltaTime;
        float clampedX = Mathf.Clamp(transform.position.x, -xlimit, xlimit);
        transform.position = new Vector3(clampedX, transform.position.y, transform.position.z);
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        FindAnyObjectByType<GameManager>().GameOver();
    }
}
