using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class buttonFinish : MonoBehaviour
{

    [SerializeField] private Button retryButton;
    [SerializeField] private Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
        // Menambahkan fungsi RetryButton() pada tombol Retry
        retryButton.onClick.AddListener(RetryButton);

        // Menambahkan fungsi RestartButton() pada tombol Restart
        restartButton.onClick.AddListener(RestartButton);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RetryButton()
    {
        SceneManager.LoadScene("EscapeRoom");
    }

    public void RestartButton()
    {
        // Memuat scene "Level_1_Final"
        Application.Quit();
    }
}
