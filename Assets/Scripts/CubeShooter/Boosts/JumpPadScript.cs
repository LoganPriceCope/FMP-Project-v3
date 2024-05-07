using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JumpPadScript : MonoBehaviour
{
    private GameObject Player;
    public GameObject jumpPad;

    public float boostAmount;
    public float damageCooldown = 3f;

    public bool canTrigger = true;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        
    }

    public void OnTriggerEnter(Collider collision)
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
        Player.GetComponent<MovementCamera>().jumpPower = 12f;
        canTrigger = false;
        yield return new WaitForSeconds(damageCooldown);
        canTrigger = true;
        Player.GetComponent<MovementCamera>().jumpPower = 7f;
        print("JumpPad Stop");
    }
}
