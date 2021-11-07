﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class insertDiamond : MonoBehaviour, IInteractable
{

    public string UnlockItem;
    public string lock_name;
    //public bool unlocked = false;

    private GameObject inventory;

    private GameObject diamond_lock;

    public void Interact(DisplayImage currentDisplay)
    {
        // if the current selected slot has an item whose name is the same as UnlockItem, then
        if (inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite.name == UnlockItem)
        {
            Debug.Log("unlock");
            diamond_lock.SetActive(true);
            inventory.GetComponent<Inventory>().currentSelectedSlot.GetComponent<Slot>().ItemProperty = Slot.property.empty;
            inventory.GetComponent<Inventory>().currentSelectedSlot.gameObject.transform.GetChild(0).GetComponent<Image>().sprite =
                Resources.Load<Sprite>("Items/empty");
            //unlocked = true;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.Find("Inventory");
        diamond_lock = GameObject.Find(lock_name);
        diamond_lock.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}

