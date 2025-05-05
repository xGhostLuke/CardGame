using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardScript : MonoBehaviour
{
    [SerializeField] private GameObject card;
    [SerializeField] private bool isSelected;
    [SerializeField] private int damage;
    [SerializeField] private string type;

    
    void Start()
    {
        isSelected = false;
    }

    
    void Update()
    {
        if (isSelected){
            card.transform.localScale = new Vector3(5, 5);
        }else{
            card.transform.localScale = new Vector3(4, 4);
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
