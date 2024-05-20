using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Target : MonoBehaviour, IDamagable
{
    public float health;
    private PlayerSystem CurrentEnemies;
    private GameObject Player;

    public GameObject coinPrefab;

    public Canvas canvas;
   public Text healthText;
    

    public void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Update()
    {
    health = GetComponent<Target>().health;
      healthText.text = "" + health;
    }

    public void Damage(float damage)
    {
        AudioManager.Instance.PlaySFX("Hit");
        var spawnedCoin = Instantiate(coinPrefab, transform.position, transform.rotation);
        health -= GameManagerScript.instance.damageUpgradeMultiplier;
        if (health <= 0)
        {
            for(int i = 0; i < 8; i++)
            {
                Instantiate(coinPrefab, transform.position, transform.rotation);
            }
            Destroy(gameObject);
            Player.GetComponent<PlayerSystem>().currentEnemies--;
        }
    }

    public void SendBackDamageData()
    {

    }
  
}