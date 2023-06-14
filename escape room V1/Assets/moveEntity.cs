using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEntity : MonoBehaviour
{
    public float speed = 3f;
    private bool canMove = false;

    private void Start()
    {
        StartCoroutine(EnableMovement());
    }

    private IEnumerator EnableMovement()
    {
        yield return new WaitForSeconds(8f);
        canMove = true;
    }

    private void Update()
    {
        if (canMove)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
}
