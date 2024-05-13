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
        Player.GetComponent<MovementCamera>().walkSpeed = 25f;
        Player.GetComponent<MovementCamera>().runSpeed = 32f;
    }
    public void OnTriggerExit(Collider collision)
    {
        Player.GetComponent<MovementCamera>().walkSpeed = 14f;
        Player.GetComponent<MovementCamera>().runSpeed = 18f;
    }
}
