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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
