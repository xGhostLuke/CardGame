using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private CardScript cardScript;
    [SerializeField] private GameObject currentEnemy;
    private EnemyController enemyController;

    void Start()
    {
        currentEnemy = GameObject.FindGameObjectWithTag("Enemy");
        enemyController = currentEnemy.GetComponent<EnemyController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takeTurn(){
        if(cardScript.getType().Equals("offensive")){
            enemyController.takeDamage(cardScript.getDamage());
        }
    } 

    public void setCard(CardScript card){
        cardScript = card;
    }
}
