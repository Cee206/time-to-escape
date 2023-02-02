using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioDoorOpen : MonoBehaviour
{
    public Animator doorAnimator;
    public GameObject gameItem;
    public InventoryItemScript Inventory;
    public string keyType = "RadioKey";
    public GameObject openDoorText;
    public GameObject WrongKey;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void OnTriggerStay()
    {
        if (Inventory.currentItem == keyType)
        {
            openDoorText.SetActive(true);

        }
        else if (Inventory.currentItem != " ")  
        {
            WrongKey.SetActive(true);
        }

        if (Input.GetKey(KeyCode.E) && gameItem.activeSelf && Inventory.currentItem == keyType)
        {
            doorAnimator.SetBool("IsOpen", true);
            gameItem.SetActive(false);
            Inventory.currentItem = " ";
            openDoorText.SetActive(false);
            WrongKey.SetActive(false);
        }

    }

    void OnTriggerExit()
    {
        openDoorText.SetActive(false);
        WrongKey.SetActive(false);

    }
}