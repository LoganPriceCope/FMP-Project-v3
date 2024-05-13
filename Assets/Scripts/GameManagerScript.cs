using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public float reload;
    public float playerSpeed;
    public float gunDamage;
    public float playerHealth;
    public bool halfDamageTaken;

    public void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Start()
    {
        reload = 6;
        playerSpeed = 6f;
        gunDamage = 5;
        playerHealth = 100;
        halfDamageTaken = false;
    }
}
