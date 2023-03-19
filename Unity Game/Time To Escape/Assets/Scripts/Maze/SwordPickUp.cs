using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPickUp : MonoBehaviour
{
    public GameObject PickUpText;
    public GameObject pickupremover;
    public GameObject gameItem;

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

            if (Input.GetKey(KeyCode.E))
            {
                pickupremover.SetActive(false);
                gameItem.SetActive(true);
                PickUpText.SetActive(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        PickUpText.SetActive(false);
    }

}

