using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
        audio.Play(0);
        audio.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp) == true || OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown) == true 
            || OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight) == true || OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft) == true)
        {
            audio.UnPause();
        }

        else
        {
            audio.Pause();
        }
    }
}
