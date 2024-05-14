using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    private GameObject Player;
    public GameObject jumpPad;

    public float boostAmount;
    public float damageCooldown = 1.5f;

    public bool canTrigger = true;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    /*public void OnTriggerEnter(Collider collision)
    {
        Player.GetComponent<MovementCamera>().jumpPower = 15;
        Player.GetComponent<MovementCamera>().ForceJump();
    }*/
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<MovementCamera>().jumpPower = 15;
            Player.GetComponent<MovementCamera>().ForceJump();
        }
    }
    public void OnTriggerExit(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player.GetComponent<MovementCamera>().jumpPower = 8;
        }
    }

    /* public void OnTriggerEnter(Collider collision)
     {
         if (canTrigger)
         {
             if (collision.gameObject.tag == "Player")
             {
                 print("WORKS");
                 StartCoroutine(JumpPadCooldown());
             }
         }
     }

     public IEnumerator JumpPadCooldown()
     {
         print("JumpPad activated");
         Player.GetComponent<MovementCamera>().jumpPower = 15f;
        // canTrigger = false;
         yield return new WaitForSeconds(damageCooldown);
         //canTrigger = true;
         Player.GetComponent<MovementCamera>().jumpPower = 4f;
         print("JumpPad Stop");
     }
    */
}
