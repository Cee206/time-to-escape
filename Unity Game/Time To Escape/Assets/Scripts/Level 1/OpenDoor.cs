using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public GameObject gameItem;
    public GameObject openDoorText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerStay()
    { 
        if (gameItem.activeSelf)
        {
            openDoorText.SetActive(true);
            
        }

        if (Input.GetKey(KeyCode.E) && gameItem.activeSelf)
        {
            doorAnimator.SetBool("IsOpen", true);
            gameItem.SetActive(false);
            openDoorText.SetActive(false);
        }
       
       
         
        
    }
    void OnTriggerExit()
    {
        openDoorText.SetActive(false);
        
    }

}
