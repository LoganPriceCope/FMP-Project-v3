using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WalkspeedPadScript : MonoBehaviour
{
    private GameObject Player;
    public GameObject speedPad;

    public float boostAmount;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<MovementCamera>().walkSpeed = 25f;
            Player.GetComponent<MovementCamera>().runSpeed = 32f;
        }
           
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<MovementCamera>().walkSpeed = GameManagerScript.instance.movementSpeedUpgradeMultiplier;
            Player.GetComponent<MovementCamera>().runSpeed = GameManagerScript.instance.movementSpeedUpgradeMultiplier + 10f;
        }
    }
}
