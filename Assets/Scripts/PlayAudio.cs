using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlayAudio : MonoBehaviour
{
    public GameObject play_sound;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Play()
    {
        print("YOU'VE BEEN SEEN!");

        play_sound.GetComponent<AudioSource>().Play();
    }

    public void Stop()
    {
        print("EY! WHEREDY GOOO?!");

        play_sound.GetComponent<AudioSource>().Stop();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
