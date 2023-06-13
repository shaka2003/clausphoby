using UnityEngine;
using UnityEngine.SceneManagement;

public class VRGameOver : MonoBehaviour
{
    public float gameOverTime = 120f; // Waktu dalam detik sebelum Game Over
    public string gameOverScene = "GameOverScene"; // Nama scene untuk Game Over

    private float timer;
    private bool isGameOver = false;

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Level1_Final")
        {
            StartTimer();
        }
    }

    private void StartTimer()
    {
        timer = gameOverTime;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                // Pemain telah kalah, pindah ke layar Game Over
                SceneManager.LoadScene(gameOverScene);
                isGameOver = true;
            }
        }
    }
}
