using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float currentTime;
    [SerializeField] private float displayTime;
    [SerializeField] private TMP_Text displayText;
    [SerializeField] private GameObject gameOverBox;

    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        displayTime = Mathf.Round(currentTime);

        if(currentTime < 0)
        {
            displayText.text = "Game Over";
            gameOverBox.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            displayText.text = displayTime.ToString() + "s";
        }
    }
}
