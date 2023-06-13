using UnityEngine;
using TMPro;

public class VRTimer : MonoBehaviour
{
    public float totalTime = 120f; // Waktu total dalam detik
    private float timer;
    private TextMeshProUGUI timerText;

    private void Start()
    {
        timer = totalTime;
        timerText = GetComponent<TextMeshProUGUI>();
    }

    private void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            timer = 0;
        }

        // Format waktu menjadi menit:detik
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer % 60f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);

        // Tampilkan waktu pada TextMeshPro
        timerText.text = timeString;
    }
}
