using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    [SerializeField] private bool isSelected;
    private GameObject accept_item;
    private GameObject discard_item;
    void Awake()
    {
        isSelected=false;
        accept_item = GameObject.Find("accept_item");
        discard_item = GameObject.Find("discard_item");
    }

    void Update(){
        accept_item.SetActive(isSelected);
        discard_item.SetActive(isSelected);
    }
    public bool IsSelected() {
        return isSelected;
    }

    public void SetSelected(bool selected){
        isSelected = selected;
    }
}
