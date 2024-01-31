using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager: MonoBehaviour
{
    public Sound[] sounds;
    public static audioManager instance;


    private void Awake()
    {      
        if(instance == null )
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        foreach (var sound in sounds)
        {
            sound.audioSource = gameObject.AddComponent<AudioSource>();
            sound.audioSource.clip = sound.clip;
            sound.audioSource.volume = sound.volume;
            sound.audioSource.pitch = sound.pitch;
            sound.audioSource.loop = sound.loop;
            sound.audioSource.playOnAwake = false;           
        }
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null)
        {
            Debug.Log("Ses : " + name + " Bulunamadý!!");
        }
        s.audioSource.Play();
    }
}
