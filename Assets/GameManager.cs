using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float score;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;
    void Start()
    {
        
    }
    public void GameOver()
    {
        Time.timeScale = 0f; // Pause the game
        gameOverText.gameObject.SetActive(true); // Show the game over text
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        if(Time.timeScale == 0f && Keyboard.current.spaceKey.isPressed)
        {
            RestartGame();
        }
        void RestartGame()
        {
            Time.timeScale = 1f; // Resume the game
           UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
