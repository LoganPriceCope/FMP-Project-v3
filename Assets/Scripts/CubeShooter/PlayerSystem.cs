using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSystem : MonoBehaviour
{
    public Text healthUI;
    public float totalHP = 100f;
    public float currentHP;
    void Start()
    {
        currentHP = totalHP;
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
    }

    void Respawn()
    {
        currentHP = totalHP;
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
