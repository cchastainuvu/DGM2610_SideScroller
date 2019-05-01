using UnityEngine;
using System.Collections;

//Resource: Connor Cox (1610)

[RequireComponent(typeof(AudioSource))]
public class AudioChanger : MonoBehaviour
{
    public AudioSource Audio1, Audio2;
    public bool _looping;
    
    
    
    private void FixedUpdate()
    {
        if (!Audio1.isPlaying && !_looping)
        {
            Audio2.Play();
            _looping = true;
        }
    }
}
