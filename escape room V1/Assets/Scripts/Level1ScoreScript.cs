 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Level1ScoreScript : MonoBehaviour
{
    [SerializeField] private int score;
    [SerializeField] private int finalScore;
    [SerializeField] private UnityEvent winAction;

    public void updateScore()
    {
        score++;
        if(score == finalScore)
        {
            winAction.Invoke();
            
        }
    }
}
 