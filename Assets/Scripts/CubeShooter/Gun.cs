using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GunData gunData;
    [SerializeField] Transform muzzle;

    float timeSinceLastShot;
    private void Start()
    {
        PlayerShoot.shootInput += Shoot;
        PlayerShoot.reloadInput += StartReload;
    }

    public void StartReload()
    {
        if (!gunData.reloading)
        {
            StartCoroutine(Reload());
        }
    }

    private IEnumerator Reload()
    {
        gunData.reloading = true;

        yield return new WaitForSeconds(gunData.reloadTime);

        gunData.currentAmmo = gunData.magSize;
        gunData.reloading = false;
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
                }
                gunData.currentAmmo--;
                timeSinceLastShot = 0;
              //  OnGunShot();
            }
        }
    }

    private void Update()
    {
        timeSinceLastShot += Time.deltaTime;
        Debug.DrawRay(muzzle.position, muzzle.forward);
    }

   /* private void OnGunShot()
    {
        throw new NotImplementedException();
    }
   */
}
