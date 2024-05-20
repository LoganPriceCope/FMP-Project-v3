using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public float playerSpeed;
    public float playerHealth;
    public bool halfDamageTaken;

    public float goldCoins;
    public float cubeCoins;

    // || INNER PEACE ||
    public float innerPeaceCost = 100f;

    // || CLICKER UPGRADES ||

    // Tapper Upgrade
    public float tapperUpgradePurchases = 1f;
    public float tapperUpgradeMultiplier = 1f;
    public float tapperUpgradeCostBoost;
    public float tapperUpgradeCost = 10f;

    // Helping Hand Upgrade
    public float helpingHandUpgradePurchases = 0f;
    public float helpingHandUpgradeMultiplier = 0f;
    public float helpingHandUpgradeCostBoost;
    public float helpingHandUpgradeCost = 10f;

    // Super Tapper Upgrade
    public float superTapperUpgradePurchases = 0f;
    public float superTapperUpgradeMultiplier = 0f;
    public float superTapperUpgradeCostBoost;
    public float superTapperUpgradeCost = 10f;

    // Tapping Factory Upgrade
    public float tappingFactoryUpgradePurchases = 0f;
    public float tappingFactoryUpgradeMultiplier = 0f;
    public float tappingFactoryUpgradeCostBoost;
    public float tappingFactoryUpgradeCost = 10f;

    // Tapping Universe Upgrade
    public float tappingUniverseUpgradePurchases = 0f;
    public float tappingUniverseUpgradeMultiplier = 0f;
    public float tappingUniverseUpgradeCostBoost;
    public float tappingUniverseUpgradeCost = 10f;

    // || COMBAT UPGRADES ||

    // Reload Upgrade
    public float reloadUpgradePurchases = 1f;
    public float reloadUpgradeMultiplier = 6f;
    public float reloadUpgradeCostBoost;
    public float reloadUpgradeCost = 10f;

    // Damage Upgrade
    public float damageUpgradePurchases = 1f;
    public float damageUpgradeMultiplier = 25f;
    public float damageUpgradeCostBoost;
    public float damageUpgradeCost = 10f;

    // Movement Speed Upgrade
    public float movementSpeedUpgradePurchases = 1f;
    public float movementSpeedUpgradeMultiplier = 5f;
    public float movementSpeedUpgradeCostBoost;
    public float movementSpeedUpgradeCost = 10f;

    // Health Speed Upgrade
    public float healthUpgradePurchases = 1f;
    public float healthUpgradeMultiplier = 5f;
    public float healthUpgradeCostBoost;
    public float healthUpgradeCost = 10f;

    // Half Damage Taken Upgrade
    public float hdtUpgradePurchases = 1f;
    public bool hdtUpgradeMultiplier = false;
    public float hdtUpgradeCostBoost;
    public float hdtUpgradeCost = 10f;


    // || GAME MANAGER FUNCTIONALITY ||

    public static GameManagerScript instance;

    public void Awake()
    {
        if (instance == null)
        {
            // if instance is null, store a reference to this instance
            instance = this;
            DontDestroyOnLoad(gameObject);
            print("dont destroy");
        }
        else
        {
            // Another instance of this gameobject has been made so destroy it
            // as we already have one
            print("do destroy");
            Destroy(gameObject);
        }

    }
}
