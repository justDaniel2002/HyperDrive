using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : Singleton<AudioController>
{
    [Range(0,1)]
    public float musicVol;
    [Range(0, 1)]
    public float soundVol;
    public AudioSource musicAus;
    public AudioSource soundAus;
    public AudioClip[] backgroubdMusics;
    public AudioClip explosionSound;
    public AudioClip countingSound;

    private void Awake()
    {
        MakeSingleton(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        PlayBackgroundMusis();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayBackgroundMusis()
    {
        if(musicAus && backgroubdMusics != null && backgroubdMusics.Length > 0)
        {
            int randIdx = Random.Range(0, backgroubdMusics.Length);

            if (backgroubdMusics[randIdx])
            {
                musicAus.clip = backgroubdMusics[randIdx];
                musicAus.volume = musicVol;
                musicAus.Play();
            }
        }
    }

    public void PlaySound(AudioClip sound)
    {
        if(soundAus && sound)
        {
            soundAus.volume = soundVol;
            soundAus.PlayOneShot(sound);
        }
    }

    public void StopMusic()
    {
        if (musicAus)
        {
            musicAus.Stop();
        }
    }

    public void PlayCountingSound()
    {
        PlaySound(countingSound);
    }

    public void PlayExlodeSound()
    {
        PlaySound(explosionSound);
    }
}
