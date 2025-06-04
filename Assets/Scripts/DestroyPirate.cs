using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPirate : MonoBehaviour
{
    private bool hovering = false;
    private void Update()
    {
        if (hovering && Input.GetKeyDown(KeyCode.Mouse0))
        {
            Destroy(gameObject);
        }

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
            hovering = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Cursor"))
            hovering = false;
    }
}
