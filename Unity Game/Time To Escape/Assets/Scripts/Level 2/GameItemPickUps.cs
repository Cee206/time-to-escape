using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItemPickUps : MonoBehaviour
{

    public GameObject PickUpText;
    public string DifferentPotions = "GreenPotion";
    public GameObject ItemInHand;
    public InventoryItemScript Inventory;
    void Start()
    {
        ItemInHand.SetActive(false);
        PickUpText.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E) && Inventory.currentItem == " ")
            {
                this.gameObject.SetActive(false);

                ItemInHand.SetActive(true);

                Inventory.currentItem = DifferentPotions;

                PickUpText.SetActive(false);

            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }



}
