using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour
{
    private AudioSource ballSound;
    private Rigidbody ballRigidbody;
    
    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody>();
        ballSound = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Player") & !collision.gameObject.CompareTag("Ball"))
        {
            ballSound.volume = ballRigidbody.velocity.magnitude / 4f;
            ballSound.Play();
        }
    }
}
