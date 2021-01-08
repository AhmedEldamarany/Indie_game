using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioClip[] clips;
    private AudioSource source;
    void Start()
    {
        source = GetComponent<AudioSource>();
        clips = Resources.LoadAll<AudioClip>("Audio/Positive");
    }

   public void PlayAudio()
    {
        source.clip = clips[Random.Range(0, clips.Length-1)];
        source.Play();
    }
}
