using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class FinalDoor : MonoBehaviour
{
    public Animation hingehere;
    public TMP_Text L1;
    public TMP_Text L2;
    public TMP_Text L3;
    public TMP_Text L4;
    public TMP_Text L5;
    public TMP_Text L6;
    public TMP_Text L7;
    public TMP_Text L8;
    public TMP_Text L9;
    public TMP_Text L10;
    bool isOpen = false;

    void Update()
    {
        if(
            L1.text == "H" &&
            L2.text == "E" &&
            L3.text == "L" &&
            L4.text == "L" &&
            L5.text == "O" &&
            L6.text == "W" &&
            L7.text == "O" &&
            L8.text == "R" &&
            L9.text == "L" &&
            L10.text == "D" &&
            !isOpen)
        {
            hingehere.Play();
            isOpen = true;
        }
    }

}
