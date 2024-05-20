using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSystem : MonoBehaviour
{
    public Text healthUI;
    private float totalHP;
    private float currentHP;

    public Text newCoinsText;
    public Text coinText;
    private float newCoins = 0;

    public GameObject deathFrame;

    public GameObject Player;
    public GameObject Enemy;

    // Enemy spawner script
    public float spawnRadius = 100f;
    public float minSpawnDistance = 50f;
    public int maxEnemies = 1;
    public int currentEnemies = 1;
    void Awake()
    {
        
        SpawnEnemies();
        Time.timeScale = 1;
        totalHP = GameManagerScript.instance.healthUpgradeMultiplier;
        currentHP = totalHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            print("Cointouched");
            AudioManager.Instance.PlaySFX("Coin");
            GameManagerScript.instance.goldCoins++;
            newCoins++;
            Destroy(other.gameObject);
        }
    }

    void Update()
    {
        newCoinsText.text = "Coins Earnt: " + newCoins;
        if (currentHP <= 0)
        {
            Die();
            healthUI.text = "Respawning";
        }
        else
        {
            healthUI.text = "HEALTH: " + currentHP;
        }  

        if (currentEnemies < maxEnemies)
        {
            SpawnEnemiesTwo();
        }
        coinText.text = "COINS: " + GameManagerScript.instance.goldCoins;
    }

    void Respawn()
    {
        currentHP = totalHP;
    }

    void SpawnEnemies()
    {
        if (currentEnemies == maxEnemies)
        {
            for (int i = 0; i < maxEnemies; i++)
            {
                Vector3 spawnPosition = GetRandomSpawnPosition();
                Instantiate(Enemy, spawnPosition, Quaternion.identity);
                currentEnemies++;
            }
        }
    }

    void SpawnEnemiesTwo()
    {
        if (currentEnemies < maxEnemies)
        {
            for (int i = 0; i < maxEnemies; i++)
            {
                Vector3 spawnPosition = GetRandomSpawnPosition();
                Instantiate(Enemy, spawnPosition, Quaternion.identity);
                currentEnemies++;
            }
        }
    }

    Vector3 GetRandomSpawnPosition()
    {
        Vector3 randomDirection = Random.insideUnitSphere * spawnRadius;
        randomDirection += Player.transform.position;
        randomDirection.y = 0f;

        while (Vector3.Distance(randomDirection, Player.transform.position) < minSpawnDistance)
        {
            randomDirection = Random.insideUnitSphere * spawnRadius;
            randomDirection += Player.transform.position;
            randomDirection.y = 0f;
        }

        return randomDirection;
    }

    void Die()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        deathFrame.active = true;
    }

    public void TakeDamage(float damage)
    {
        if (currentHP <= 0)
        {
            print("Waiting for the player to respawn.");
        }
        else
        {
            print("E");
            currentHP = currentHP - damage;
        }
    }
}
