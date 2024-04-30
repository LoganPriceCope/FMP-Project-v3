using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour, IDamagable
{
    public float health;

    public Canvas canvas;
    public TextMeshProUGUI healthText;
    public void Update()
    {
      //  health = GetComponent<EnemyScript>().enemyHealth;
        healthText.text = "" + health;
    }

    public void Damage(float damage)
    {

        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void SendBackDamageData()
    {

    }
}