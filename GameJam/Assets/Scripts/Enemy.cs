using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 15;
    public GameObject deathEffect;
  
    public void TakeDmg(int dmg)
    {
        health -= dmg;

        if(health <= 0)
        {
            Die();
        }
    }
    
    public void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(GameObject.Find("Thunder(Clone)"), 0.6f);
        Destroy(gameObject);
        Destroy(transform.parent.gameObject);
    }
}
