﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int hp = 100;

    public GameObject deathEffect;
    
    public void TakeDamage (int damage)
    {
        hp -= damage;

        if(hp <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}