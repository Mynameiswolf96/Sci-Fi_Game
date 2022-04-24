using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    private AudioSource audioScr;
    private float musicVolue = 1f;
    // Start is called before the first frame update
    void Start()
    {
        audioScr = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        audioScr.volume = musicVolue;        
        
    }
    public void SetVolume(float volume)
    {
        musicVolue = volume;
    }
}
