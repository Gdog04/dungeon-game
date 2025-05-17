using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Key : MonoBehaviour
{
    public AudioClip pickupSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (pickupSound)
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);

            GameManager.Instance.CollectKey();
            Destroy(gameObject);
        }
    }
}
