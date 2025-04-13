using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum SoundType
{
    BUTTONCLICK,
    SHOTFIRED,
    BACKGROUNDMUSIC
}

[System.Serializable]
public class Sound
{
    public AudioClip soundClip;
    public SoundType type;
}

public class SoundManager : MonoBehaviour
{
    [SerializeField] private Sound[] sounds;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioSource backgroundMusic;

    private static SoundManager instance;
    public static SoundManager Instance {  get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        PlayBackgroundMusic();
    }

    public void PlaySfxSound(SoundType soundType)
    {
        AudioClip audioClip = GetSound(soundType);
        audioSource.PlayOneShot(audioClip); 
    }

    private void PlayBackgroundMusic()
    {
        AudioClip audioClip = GetSound(SoundType.BACKGROUNDMUSIC);
        backgroundMusic.clip = audioClip;
        backgroundMusic.Play();
    }

    private AudioClip GetSound(SoundType type)
    {
        Sound soundObject = Array.Find(sounds, sound => sound.type == type);
        return soundObject.soundClip;
    }
}
