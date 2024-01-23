using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    private void Awake(){
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public AudioClip MusicClip;

    public AudioSource Music, GamePlay_Effect, AudioEffect;

    public void PlayMusic(string s){
      Music.Stop();
      Music.clip = MusicClip;
      Music.Play();
    }
}
