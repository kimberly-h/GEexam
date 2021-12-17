using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class SoundManager : MonoBehaviour
{
    public SoundFX[] sounds;
    public static SoundManager instance;

    // Start is called before the first frame update
    void Awake()
    {
        foreach (SoundFX s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void Play(string name)
    {
        SoundFX s = Array.Find(sounds, sound => sound.name == name);
        if (!s.source.isPlaying)
        {
            s.source.Play();
        }
    }
}