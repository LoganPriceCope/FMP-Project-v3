using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Target : MonoBehaviour, IDamagable
{
    public float health;
    private PlayerSystem CurrentEnemies;
    private GameObject Player;

    public Canvas canvas;
    public TextMeshProUGUI healthText;

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
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
            Player.GetComponent<PlayerSystem>().currentEnemies--;
        }
    }

    public void SendBackDamageData()
    {

    }
}