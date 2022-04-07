using Microsoft.Win32.SafeHandles;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkaterBehavior : MonoBehaviour
{
    AudioSource chords;
    AudioSource noChords;
    // Start is called before the first frame update
    void Start()
    {
        chords = GameObject.Find("Chords").GetComponent<AudioSource>();
        noChords = GameObject.Find("No Chords").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        chords.mute = false;
        noChords.mute = true;
    }

    void OnTriggerExit(Collider other)
    {
        chords.mute = true;
        noChords.mute = false;
    }
}
