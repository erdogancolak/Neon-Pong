using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Sound 
{
    public AudioClip clip;
    public string name;
    [Range(0,1)] public float volume;
    [Range(0, 1)] public float pitch;
    public bool loop;
    [HideInInspector] public AudioSource audioSource;
}
