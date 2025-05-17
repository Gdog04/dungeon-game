using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trap : MonoBehaviour
{
    public int damage = 1;
    public AudioClip trapSound;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (trapSound)
                AudioSource.PlayClipAtPoint(trapSound, transform.position);

            GameManager.Instance.TakeDamage(damage);
        }
    }
}
