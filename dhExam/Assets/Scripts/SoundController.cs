using UnityEngine.Audio;
using UnityEngine;

public class SoundController
{
    public string name;

    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume;
    [Range(1f, 3f)]
    public float pitch;

    public SoundFX source;
}