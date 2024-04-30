using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;

public class Gun : MonoBehaviour
{
    [SerializeField] GunData gunData;
    [SerializeField] Transform muzzle;

    public GameObject player;
    public GameObject enemy;

    PlayerSystem takeDamage;

    public Text ammoAmountText;
    public Text magAmountText;
    public Text reloadText;

    public ParticleSystem bulletHit;

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed = 1000f;

    float timeSinceLastShot;

    Animator anim;
    private void Start()
    {
        gunData.currentAmmo = 46;
        gunData.magSize = 46;
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;

        anim = GetComponent<Animator>();
    }

    public void StartReload()
    {
        if (!gunData.reloading)
        {
            StartCoroutine(Reload());
        }
    }
    //find children, when r pressed anim starts on children

    private IEnumerator Reload()
    {
        anim.SetBool("reload", true);

        reloadText.text = "RELOADING";
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;
        gunData.reloading = false;
        reloadText.text = "";
    }
    private bool CanShoot() => !gunData.reloading && timeSinceLastShot > 1f / (gunData.fireRate / 60f);

    public void OnDestroy()
    {
        PlayerShoot.shootInput -= Shoot;
        PlayerShoot.reloadInput -= StartReload;
    }

    public void Shoot()
    {
        if (gunData.currentAmmo > 0)
        {
            if (CanShoot())
            {
 
                if (Physics.Raycast(muzzle.position, transform.forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamagable damagable = hitInfo.transform.GetComponent<IDamagable>();
                    Debug.Log(hitInfo.transform.name);
                    damagable?.Damage(gunData.damage);
                    //takeDamage.TakeDamage();
                   // player.GetComponent<PlayerSystem>().TakeDamage();
                }
                gunData.currentAmmo--;
                timeSinceLastShot = 0;
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
                bulletHit.Play();
                //  OnGunShot();
            }
        }
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        Debug.DrawRay(muzzle.position, muzzle.forward);

        ammoAmountText.text = "" + gunData.currentAmmo;
        magAmountText.text = "" + gunData.magSize;
    }

   /* private void OnGunShot()
    {
        throw new NotImplementedException();
    }
   */
}
