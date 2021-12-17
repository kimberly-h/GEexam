using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class SoundFX : MonoBehaviour
{
    public SoundController[] sounds;
    public bool SilencerSwitch = false;
    public static SoundFX instance;

    [DllImport("SwitchSound")]
    private static extern float Silencer();
    [DllImport("SwitchSound")]
    private static extern float SilencerPitch();

    // Start is called before the first frame update
    void Awake()
    {
        foreach (SoundController s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    private void FixedUpdate()
    {
        if (SilencerSwitch == true)
        {
            foreach (SoundController s in sounds)
            {
                s.source.clip = s.clip;

                s.source.volume = Silencer();
                s.source.pitch = SilencerPitch();
            }
        }
    }

    public void Play(string name)
    {
        SoundController s = Array.Find(sounds, sound => sound.name == name);
        if (!s.source.isPlaying)
        {
            s.source.Play();
        }
    }
}