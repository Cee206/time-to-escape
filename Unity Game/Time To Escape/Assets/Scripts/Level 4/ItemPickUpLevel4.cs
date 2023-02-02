using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpLevel4 : MonoBehaviour
{
    public GameObject ItemInHand;
    public GameObject PickUpText;
    public InventoryItemScript Inventory;

    // Start is called before the first frame update
    void Start()
    {
        ItemInHand.SetActive(false);
        PickUpText.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PickUpText.SetActive(true);

            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);

                ItemInHand.SetActive(true);

                PickUpText.SetActive(false);
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }
}
