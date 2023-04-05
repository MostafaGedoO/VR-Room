using System.Collections;
using System.Collections.Generic;
using System;
using Unity.Mathematics;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform secAnlog;
    [SerializeField] private Transform minAnlog;
    [SerializeField] private Transform hoursAnlog;
    
    private float secT;
    private float minT;
    private float hourT;

    private quaternion lastSec;

    private void Start()
    {
        lastSec = secAnlog.localRotation;
    }
    
    void Update()
    {
        secAnlog.localRotation = Quaternion.Euler(DateTime.Now.Second * 6f,0,0);
        
        if (secAnlog.localRotation != lastSec)
        {
            PlayTickSound();
            lastSec = secAnlog.localRotation;
        }
        
       minAnlog.localRotation = Quaternion.Euler(DateTime.Now.Minute * 6f,0,0);
       hoursAnlog.localRotation = Quaternion.Euler(DateTime.Now.Hour * 30f,0,0);
    }

    void PlayTickSound()
    {
        GetComponent<AudioSource>().Play();
    }
}
