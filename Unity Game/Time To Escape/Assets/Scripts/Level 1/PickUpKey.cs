using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpKey : MonoBehaviour
{
    public GameObject PickUpText;
    public Component doorcolliderhere;
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
                doorcolliderhere.GetComponent<BoxCollider>().enabled = true;
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
