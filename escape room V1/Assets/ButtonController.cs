using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    private int previousSceneIndex;

    [SerializeField] private Button retryButton;
    [SerializeField] private Button restartButton;

    private void Start()
    {
        // Mendapatkan indeks scene saat ini
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // Mendapatkan daftar scene dalam build settings
        Scene[] scenes = SceneManager.GetAllScenes();

        // Mencari indeks scene sebelumnya
        for (int i = 0; i < scenes.Length; i++)
        {
            if (scenes[i].buildIndex == currentSceneIndex)
            {
                // Jika scene saat ini ditemukan, mengatur indeks scene sebelumnya
                previousSceneIndex = i - 1;
                break;
            }
        }

        // Menambahkan fungsi RetryButton() pada tombol Retry
        retryButton.onClick.AddListener(RetryButton);

        // Menambahkan fungsi RestartButton() pada tombol Restart
        restartButton.onClick.AddListener(RestartButton);
    }

    public void RetryButton()
    {
        // Memeriksa apakah ada scene sebelumnya
        if (previousSceneIndex >= 0)
        {
            // Memuat scene sebelumnya berdasarkan indeks
            SceneManager.LoadScene(previousSceneIndex);
        }
        else
        {
            // Tidak ada scene sebelumnya, jalankan aksi tambahan atau tampilkan pesan kesalahan jika diperlukan
            Debug.LogWarning("Tidak ada scene sebelumnya.");
        }
    }

    public void RestartButton()
    {
        // Memuat scene "Level_1_Final"
        SceneManager.LoadScene("EscapeRoom");
    }
}
