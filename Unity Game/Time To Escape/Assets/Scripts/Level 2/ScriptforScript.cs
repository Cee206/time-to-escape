using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptforScript : MonoBehaviour
{
    public GameObject placeDown;
    public bool isFull = (false);
    public List<GameObject> Potions;
    public InventoryItemScript Inventory;
    public GameObject ItemInHand;
    private int keepTrackOfPotionCounter = 0;
    public string PotionType = "GreenPotion";

    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject Potion in Potions)
        {
            Potion.SetActive(false);
        }

    }

    // Update is called once per frame
    void OnTriggerStay()

    {
        if (Inventory.currentItem == PotionType)
        {
            placeDown.SetActive(true);

        }

        if (Input.GetKey(KeyCode.E) && Inventory.currentItem == PotionType)
        {
            
            Potions[keepTrackOfPotionCounter].SetActive(true);
            ItemInHand.SetActive(false);
            Inventory.currentItem = " ";
            keepTrackOfPotionCounter = keepTrackOfPotionCounter + 1;
            placeDown.SetActive(false);
        }

        if(keepTrackOfPotionCounter == Potions.Count)
        {
            isFull = (true);
        }



    }
    void OnTriggerExit()
    {
        placeDown.SetActive(false);

    }
}
