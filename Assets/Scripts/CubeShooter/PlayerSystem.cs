using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSystem : MonoBehaviour
{
    public Text healthUI;
    public float totalHP = 100f;
    public float currentHP;

    public GameObject Player;
    public GameObject Enemy;

    // Enemy spawner script
    public float spawnRadius = 100f;
    public float minSpawnDistance = 50f;
    public int maxEnemies = 1;
    public int currentEnemies = 1;

    void Start()
    {
        currentHP = totalHP;
        SpawnEnemies();
    }



    void Update()
    {
        if (currentHP <= 0)
        {
            Die();
            healthUI.text = "Respawning";
        }
        else
        {
            healthUI.text = currentHP + "HP";
        }  

        if (currentEnemies < maxEnemies)
        {
            SpawnEnemiesTwo();
        }
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
        print("Dies");
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
