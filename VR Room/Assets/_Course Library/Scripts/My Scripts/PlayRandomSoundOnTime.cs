using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayRandomSoundOnTime : MonoBehaviour
{

    [SerializeField] private List<AudioClip> audioClips;
    private AudioSource soundPlayer;

    void Start()
    {
        soundPlayer = GetComponent<AudioSource>();
        InvokeRepeating("PlayRandomSound", 5, 10);
    }


    private void PlayRandomSound()
    {
        int _randomIndex = Random.Range(0, audioClips.Count);
        soundPlayer.PlayOneShot(audioClips[_randomIndex]);
    }
}
