using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Door : MonoBehaviour
{
    public AudioClip openSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && GameManager.Instance.keysCollected >= GameManager.Instance.totalKeys)
        {
            if (openSound)
                AudioSource.PlayClipAtPoint(openSound, transform.position);

            GameManager.Instance.WinGame();
        }
    }
}
