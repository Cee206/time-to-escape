using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayDetection : MonoBehaviour
{
    
    public Animator doorAnimator; 
    // Start is called before the first frame update
    
    void OnTriggerEnter()
    {
        doorAnimator.SetBool("IsOpen", false);    
    }
}
