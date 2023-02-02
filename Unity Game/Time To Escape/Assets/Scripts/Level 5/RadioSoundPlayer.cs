using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSoundPlayer : MonoBehaviour
{
    
    public AudioSource radioSound;

    private void OnTriggerStay(Collider other)
    {


        if (Input.GetKey(KeyCode.E) && !radioSound.isPlaying)
        {
            radioSound.Play(0);
            
        }


    }
}