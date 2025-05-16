using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    [SerializeField] private GameObject card;
    [SerializeField] private bool isSelected;
    [SerializeField] private int damage;
    [SerializeField] private string type;
    [SerializeField] private int size;
    [SerializeField] private int selSize;

    
    void Start()
    {
        isSelected = false;
    }

    
    void Update()
    {
        if (isSelected){
            card.transform.localScale = new Vector3(selSize, selSize);
        }else{
            card.transform.localScale = new Vector3(size, size);
        }
    }

    public int getDamage(){
        return damage;  
    }

    public string getType(){
        return type;
    }

    public bool IsSelected(){
        return isSelected;
    }

    public void SetSelected(bool selected){
        isSelected = selected;
    }
}
