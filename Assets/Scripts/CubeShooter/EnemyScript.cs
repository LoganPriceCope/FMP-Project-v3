using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyScript : MonoBehaviour
{

    private GameObject Player;
    public GameObject Enemy;
    public float speed = 0.005f;



    public TextMeshProUGUI cooldownText;



    public float damage;

    public float damageCooldown = 3f;

    private bool canTrigger = true;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        Enemy.transform.position = Vector3.MoveTowards(Enemy.transform.position, Player.transform.position, speed);
        Vector3 direction = Player.transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = rotation;
    }

    public void OnTriggerEnter(Collider collision)
    {
        if (canTrigger)
        {
            if (collision.gameObject.tag == "Player")
            {
                Player.GetComponent<PlayerSystem>().TakeDamage(damage);
                StartCoroutine(StartCoolDown());
            }
        } 
    }


    public IEnumerator StartCoolDown()
    {
        cooldownText.text = "COOLDOWN";
        canTrigger = false;
        yield return new WaitForSeconds(damageCooldown);
        canTrigger = true;
        cooldownText.text = "";
    }
}
