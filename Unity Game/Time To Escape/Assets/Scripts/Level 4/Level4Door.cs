using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Level4Door : MonoBehaviour
{
    public Animator doorAnimator;
    public TMP_Text L1;
    public TMP_Text L2;
    public TMP_Text L3;
    bool isOpen = false;

    void Update()
    {
        if (
            L1.text == "S" &&
            L2.text == "C" &&
            L3.text == "H" && !isOpen)
        {
            doorAnimator.SetBool("IsOpen", true);
            isOpen = true;
        }
    }

}
