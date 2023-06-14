using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class TrapLvl2 : MonoBehaviour
{
    // public GameObject jumpscareObject;
    // public AudioClip soundEffect;
    public float delayBeforeSceneChange = 1f;
    private bool trapGrabbed = false;

    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onSelectEntered.AddListener(OnGrabbed);
    }

    private void Update()
    {
        if (trapGrabbed && delayBeforeSceneChange > 0)
        {
            delayBeforeSceneChange -= Time.deltaTime;
            if (delayBeforeSceneChange <= 0)
            {
                // Change the scene here
                SceneManager.LoadScene("Level 3");
            }
        }
    }

    private void OnGrabbed(XRBaseInteractor interactor)
    {
        if (gameObject.CompareTag("Trap"))
        {
            // Trap object grabbed by player
            trapGrabbed = true;

            // Activate the jumpscare object
            // jumpscareObject.SetActive(true);

            // // Play the sound effect
            // AudioSource.PlayClipAtPoint(soundEffect, transform.position);
        }
    }
}
