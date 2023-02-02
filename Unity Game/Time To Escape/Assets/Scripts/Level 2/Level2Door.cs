using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Door : MonoBehaviour
{
    public ScriptforScript RedScript;
    public ScriptforScript GreenScript;
    public ScriptforScript PurpleScript;
    public Animator doorAnimator;
    public bool isOpen = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (RedScript.isFull == true && GreenScript.isFull == true && PurpleScript.isFull == true && isOpen == false)
        {

            doorAnimator.SetBool("IsOpen", true);
            isOpen = true;
        }
    }
}