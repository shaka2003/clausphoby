using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeOnTrigger : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("LoadScene") && collision.gameObject.name == "ChangeScene" &&
            gameObject.CompareTag("Player") && gameObject.name == "PlayerMesh")
        {
            SceneManager.LoadScene("Level1_Final");
        }
    }
}


