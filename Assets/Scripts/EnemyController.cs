using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    
    [SerializeField] private int currentHealth;
    [SerializeField] private int maxHealth;
    
    private GameObject healthbar;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar = GameObject.FindGameObjectWithTag("Healthbar");
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.transform.localScale = new Vector3(currentHealth/100f, 0.1f, 1);
    }

    public void takeDamage(int ammount){
        currentHealth -= ammount;
    }
}
