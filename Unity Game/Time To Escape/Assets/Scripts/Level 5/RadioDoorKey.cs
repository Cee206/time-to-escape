using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioDoorKey : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject pickupremover;
    public GameObject gameItem;
    public InventoryItemScript Inventory;
    public string keyType = "RadioKey";

    // Start is called before the first frame update
    void Start()
    {
        gameItem.SetActive(false);

    }

    // Update is called once per frame
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E) && Inventory.currentItem == " ")
            {
                
                pickupremover.SetActive(false);
                gameItem.SetActive(true);
                PickUpText.SetActive(false);
                Inventory.currentItem = keyType;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }

}
