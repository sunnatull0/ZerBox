using System.Collections;
using UnityEngine;

public class AudioManager : GenericSingletonClass<AudioManager>
{
    [SerializeField] private AudioClip shotSound;
    [SerializeField] private AudioSource audioSource;


    public void PlayShot() // тут играть нужный звук
    {
        audioSource.PlayOneShot(shotSound);
    }
}
