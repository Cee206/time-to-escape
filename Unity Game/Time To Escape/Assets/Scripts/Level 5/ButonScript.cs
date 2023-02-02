using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ButonScript : MonoBehaviour
{
    public TMP_Text letters;
    public Animation buttonAnimation;
    List<string> letterList = new List<string> { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z" };
    int letterCounter = 0;
    bool playerIsColliding = false;
    public GameObject pressButton;


    void Update()
    {
    
        if (playerIsColliding && Input.GetKeyUp(KeyCode.E))
        {
            buttonAnimation.Stop();
            buttonAnimation.Play();
            
            letterCounter++;
            if(letterCounter == 26)
            {
                letterCounter = 0;
            }
            letters.text = letterList[letterCounter];
            
        }

        if (playerIsColliding && Input.GetKeyUp(KeyCode.Q))
        {
            buttonAnimation.Stop();
            buttonAnimation.Play();
            
            
            letterCounter--;
            if (letterCounter == -1)
            {
                letterCounter = 25;
            }
            letters.text = letterList[letterCounter];

        }

    }

    void OnTriggerEnter(Collider other)
    {
        playerIsColliding = true;
        
    }

    void OnTriggerStay()
    {
        pressButton.SetActive(true);
    }

    void OnTriggerExit(Collider other)
    {
        playerIsColliding = false;
        pressButton.SetActive(false);
    }
}
