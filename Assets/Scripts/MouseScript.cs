using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    private GameController controller;
    void Start()
    {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero);

        if (hit.collider != null){
            if(hit.collider.gameObject.tag == "Card" && Input.GetKeyDown(KeyCode.Mouse0)){
                if(hit.collider.gameObject.GetComponent<CardScript>() != null){
                    CardScript card = hit.collider.gameObject.GetComponent<CardScript>();
                    if(!card.IsSelected()){
                        card.SetSelected(true);
                        controller.setCard(card);
                    }else{
                        card.SetSelected(false);
                    }
                }
            }
        }
    }
}
