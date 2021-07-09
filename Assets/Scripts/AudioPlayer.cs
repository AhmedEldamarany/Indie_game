using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    private AudioClip[] clips;
    private AudioSource source;
    [SerializeField] AudioClip winning;
    [SerializeField] AudioClip losing;
    void Start()
    {
        source = GetComponent<AudioSource>();
        clips = Resources.LoadAll<AudioClip>("Audio/Positive");
    }

   public void PlayAudio()
    {
        if(source.isPlaying) return;
        source.clip = clips[Random.Range(0, clips.Length-1)];
        source.Play();
    }
    public void PlayWinningSound()
    {
        source.clip = winning;
        source.Play();
    }
    public void PlayGameOver()
    {
        source.clip = losing;
        source.Play();
    }
}
