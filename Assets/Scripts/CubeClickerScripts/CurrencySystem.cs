using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{

    public Text reloadUpgradeCostText;
    public Text reloadUpgradeMultiplierText;

    public Text damageUpgradeCostText;
    public Text damageUpgradeMultiplierText;

    public Text movementSpeedUpgradeCostText;
    public Text movementSpeedUpgradeMultiplierText;

    public Text healthUpgradeCostText;
    public Text healthUpgradeMultiplierText;

    public Text hdtUpgradeCostText;
    public Text hdtUpgradeMultiplierText;

    // Inner Peace
    public Text innerPeaceText;
    public GameObject innerPeaceFrame;

    // Upgrades Tapper
    public Text tapperUpgradeCostText;
    public Text tapperUpgradeMultiplierText;

    // Upgrades Helping Hand
    public Text helpingHandUpgradeCostText;
    public Text helpingHandUpgradeMultiplierText;

    // Upgrades Super Tapper
    public Text superTapperUpgradeCostText;
    public Text superTapperUpgradeMultiplierText;

    // Upgrades Tapping Factory
    public Text tappingFactoryUpgradeCostText;
    public Text tappingFactoryUpgradeMultiplierText;

    // Upgrades Tapping Universe
    public Text tappingUniverseUpgradeCostText;
    public Text tappingUniverseUpgradeMultiplierText;

    public float coinCounter = 0f;
    public float multiplier;

    public Text coinCount;
    public Text coinsPerClick;
    public Text goldCoins;
    public bool innerPeaceUnlocked;

    GameManagerScript gm;

    private void Start()
    {
        gm = GameManagerScript.instance;
        
    }

    private void Update()
    {
        goldCoins.text = "Coins: " + gm.goldCoins;
        coinCount.text = gm.cubeCoins+"";
        multiplier = 1 + (gm.helpingHandUpgradeMultiplier + gm.superTapperUpgradeMultiplier + gm.tappingFactoryUpgradeMultiplier + gm.tappingUniverseUpgradeMultiplier) * gm.tapperUpgradeMultiplier;
        coinsPerClick.text = multiplier + "c/click";

        // Reload upgrade costs
        gm.reloadUpgradeCostBoost = gm.reloadUpgradePurchases * 10;
        if (gm.reloadUpgradePurchases > 1)
        {
            gm.reloadUpgradeCost = 10f * gm.reloadUpgradePurchases * gm.reloadUpgradePurchases * gm.reloadUpgradePurchases * gm.reloadUpgradePurchases;
        }
        else
        {
            gm.reloadUpgradeCost = 10f * gm.reloadUpgradePurchases;
        }
        if (gm.reloadUpgradePurchases < 6)
        {
            reloadUpgradeCostText.text = "[" + gm.reloadUpgradeCost + "c]";
            reloadUpgradeMultiplierText.text = gm.reloadUpgradeMultiplier + "/S >" + (gm.reloadUpgradeMultiplier - 1f) + "/S";
        }
        else
        {
            reloadUpgradeCostText.text = "[MAX]";
            reloadUpgradeMultiplierText.text = gm.reloadUpgradeMultiplier + "/S";
        }

        // Damage upgrade costs
        gm.damageUpgradeCostBoost = gm.damageUpgradePurchases * 10;
        if (gm.damageUpgradePurchases > 1)
        {
            gm.damageUpgradeCost = 10f * gm.damageUpgradePurchases * gm.damageUpgradePurchases * gm.damageUpgradePurchases * gm.damageUpgradePurchases;
        }
        else
        {
            gm.damageUpgradeCost = 10f * gm.damageUpgradePurchases;
        }
        if (gm.damageUpgradePurchases < 4)
        {
            damageUpgradeCostText.text = "[" + gm.damageUpgradeCost + "c]";
            damageUpgradeMultiplierText.text = gm.damageUpgradeMultiplier + ">" + (gm.damageUpgradeMultiplier + 25f);
        }
        else
        {
            damageUpgradeCostText.text = "[MAX]";
            damageUpgradeMultiplierText.text = gm.damageUpgradeMultiplier + "";
        }

        // Movement Speed upgrade costs
        gm.movementSpeedUpgradeCostBoost = gm.movementSpeedUpgradePurchases * 10;
        if (gm.movementSpeedUpgradePurchases > 1)
        {
            gm.movementSpeedUpgradeCost = 10f * gm.movementSpeedUpgradePurchases * gm.movementSpeedUpgradePurchases * gm.movementSpeedUpgradePurchases * gm.movementSpeedUpgradePurchases;
        }
        else
        {
            gm.movementSpeedUpgradeCost = 10f * gm.movementSpeedUpgradePurchases;
        }
        if (gm.movementSpeedUpgradePurchases < 4)
        {
            movementSpeedUpgradeCostText.text = "[" + gm.movementSpeedUpgradeCost + "c]";
            movementSpeedUpgradeMultiplierText.text = gm.movementSpeedUpgradeMultiplier + ">" + (gm.movementSpeedUpgradeMultiplier + 5f) + "";
        }
        else
        {
            movementSpeedUpgradeCostText.text = "[MAX]";
            movementSpeedUpgradeMultiplierText.text = gm.movementSpeedUpgradeMultiplier + "";
        }

        // Health upgrade costs
        gm.healthUpgradeCostBoost = gm.healthUpgradePurchases * 10;
        if (gm.healthUpgradePurchases > 1)
        {
            gm.healthUpgradeCost = 10f * gm.healthUpgradePurchases * gm.healthUpgradePurchases * gm.healthUpgradePurchases * gm.healthUpgradePurchases;
        }
        else
        {
            gm.healthUpgradeCost = 10f * gm.healthUpgradePurchases;
        }
        if (gm.healthUpgradePurchases < 4)
        {
            healthUpgradeCostText.text = "[" + gm.healthUpgradeCost + "c]";
            healthUpgradeMultiplierText.text = gm.healthUpgradeMultiplier + ">" + (gm.healthUpgradeMultiplier + 5f) + "";
        }
        else
        {
            healthUpgradeCostText.text = "[MAX]";
            healthUpgradeMultiplierText.text = gm.healthUpgradeMultiplier + "";
        }

        // Half damage taken upgrade costs
        gm.hdtUpgradeCostBoost = gm.hdtUpgradePurchases * 10;
        if (gm.hdtUpgradePurchases > 1)
        {
            gm.hdtUpgradeCost = 10f * gm.hdtUpgradePurchases * gm.hdtUpgradePurchases * gm.hdtUpgradePurchases * gm.hdtUpgradePurchases;
        }
        else
        {
            gm.hdtUpgradeCost = 10f * gm.hdtUpgradePurchases;
        }
        if (gm.hdtUpgradePurchases < 2)
        {
            hdtUpgradeCostText.text = "[" + gm.hdtUpgradeCost + "c]";
            hdtUpgradeMultiplierText.text = gm.hdtUpgradeMultiplier + "";
        }
        else
        {
            hdtUpgradeCostText.text = "[MAX]";
            hdtUpgradeMultiplierText.text = gm.hdtUpgradeMultiplier + "";
        }

        // Tapper upgrade costs
        gm.tapperUpgradeCostBoost = gm.tapperUpgradePurchases * 10;
        if (gm.tapperUpgradePurchases > 1)
        {
            gm.tapperUpgradeCost = 50f * gm.tapperUpgradePurchases * gm.tapperUpgradePurchases * gm.tapperUpgradePurchases * gm.tapperUpgradePurchases;
        }
        else
        {
            gm.tapperUpgradeCost = 50f * gm.tapperUpgradePurchases;
        }
        tapperUpgradeCostText.text = "Tapper [" + gm.tapperUpgradeCost + "c]";
        tapperUpgradeMultiplierText.text = "x"+gm.tapperUpgradeMultiplier;

        // Helping hand upgrade costs
        gm.helpingHandUpgradeCostBoost = gm.helpingHandUpgradePurchases * 10 + 10;
        if (gm.helpingHandUpgradePurchases >= 1)
        {
            gm.helpingHandUpgradeCost = 10f * gm.helpingHandUpgradePurchases * 1.2f;
        }
        else
        {
            gm.helpingHandUpgradeCost = 10f;
        }
        helpingHandUpgradeCostText.text = "Helping Hand [" + gm.helpingHandUpgradeCost + "c]";
        helpingHandUpgradeMultiplierText.text = "+" + gm.helpingHandUpgradeMultiplier;

        // Super tapper upgrade costs
        gm.superTapperUpgradeCostBoost = gm.superTapperUpgradePurchases * 10 + 10;
        if (gm.superTapperUpgradePurchases >= 1)
        {
            gm.superTapperUpgradeCost = 500f * gm.superTapperUpgradePurchases * 1.4f;
        }
        else
        {
            gm.superTapperUpgradeCost = 500f;
        }
        superTapperUpgradeCostText.text = "Super Tapper [" + gm.superTapperUpgradeCost + "c]";
        superTapperUpgradeMultiplierText.text = "+" + gm.superTapperUpgradeMultiplier;

        // Tapping factory upgrade costs
        gm.tappingFactoryUpgradeCostBoost = gm.tappingFactoryUpgradePurchases * 10 + 10;
        if (gm.tappingFactoryUpgradePurchases >= 1)
        {
            gm.tappingFactoryUpgradeCost = 10000f * gm.tappingFactoryUpgradePurchases * 1.5f;
        }
        else
        {
            gm.tappingFactoryUpgradeCost = 10000f;
        }
        tappingFactoryUpgradeCostText.text = "Tapping Factory [" + gm.tappingFactoryUpgradeCost + "c]";
        tappingFactoryUpgradeMultiplierText.text = "+" + gm.tappingFactoryUpgradeMultiplier;

        // Tapping Universe upgrade costs
        gm.tappingUniverseUpgradeCostBoost = gm.tappingUniverseUpgradePurchases * 10 + 10;
        if (gm.tappingUniverseUpgradePurchases >= 1)
        {
            gm.tappingUniverseUpgradeCost = 1000000f * gm.tappingUniverseUpgradePurchases * 1.6f;
        }
        else
        {
            gm.tappingUniverseUpgradeCost = 1000000f;
        }
        tappingUniverseUpgradeCostText.text = "Tapping Universe [" + gm.tappingUniverseUpgradeCost + "c]";
        tappingUniverseUpgradeMultiplierText.text = "+" + gm.tappingUniverseUpgradeMultiplier;
    }

    // || INNER PEACE ||

    public void innerPeace()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.goldCoins >= gm.innerPeaceCost && innerPeaceUnlocked == false)
        {

            gm.goldCoins = gm.goldCoins - gm.innerPeaceCost;
            innerPeaceUnlocked = true;
            innerPeaceText.text = "Inner Peace";
        }
        else if (innerPeaceUnlocked == true)
        {
            innerPeaceFrame.active = true;
        }
    }

    // || CUBE CLICKER UPGADES ||
    public void tapperUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.tapperUpgradeCost)
        {

            gm.cubeCoins = gm.cubeCoins - gm.tapperUpgradeCost;
            gm.tapperUpgradePurchases = gm.tapperUpgradePurchases + 1;
            gm.tapperUpgradeMultiplier = gm.tapperUpgradeMultiplier + 1;
            
        }
    }

    public void helpingHandUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.helpingHandUpgradeCost)
        {
            gm.cubeCoins = gm.cubeCoins - gm.helpingHandUpgradeCost;
            gm.helpingHandUpgradePurchases = gm.helpingHandUpgradePurchases + 1;
            gm.helpingHandUpgradeMultiplier = gm.helpingHandUpgradeMultiplier + 1;
        }
    }

    public void superTapperUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.superTapperUpgradeCost)
        {
            gm.cubeCoins = gm.cubeCoins - gm.superTapperUpgradeCost;
            gm.superTapperUpgradePurchases = gm.superTapperUpgradePurchases + 1;
            gm.superTapperUpgradeMultiplier = gm.superTapperUpgradeMultiplier + 10;
        }
    }

    public void tappingFactoryUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.tappingFactoryUpgradeCost)
        {
            gm.cubeCoins = gm.cubeCoins - gm.tappingFactoryUpgradeCost;
            gm.tappingFactoryUpgradePurchases = gm.tappingFactoryUpgradePurchases + 1;
            gm.tappingFactoryUpgradeMultiplier = gm.tappingFactoryUpgradeMultiplier + 100;
        }
    }

    public void tappingUniverseUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.tappingUniverseUpgradeCost)
        {
            gm.cubeCoins = gm.cubeCoins - gm.tappingUniverseUpgradeCost;
            gm.tappingUniverseUpgradePurchases = gm.tappingUniverseUpgradePurchases + 1;
            gm.tappingUniverseUpgradeMultiplier = gm.tappingUniverseUpgradeMultiplier + 1000;
        }
    }

    public void AddCube()
    {
        gm.cubeCoins = gm.cubeCoins + multiplier;
    }

    // || FIRST PERSON SHOOTER UPGRADES ||
    public void ReloadSpeedUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.reloadUpgradeCost && gm.reloadUpgradeMultiplier > 1)
        {
            gm.cubeCoins = gm.cubeCoins - gm.reloadUpgradeCost;
            gm.reloadUpgradePurchases = gm.reloadUpgradePurchases + 1;
            gm.reloadUpgradeMultiplier = gm.reloadUpgradeMultiplier - 1f;
        }
    }

    public void DamageUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.damageUpgradeCost && gm.damageUpgradeMultiplier < 100)
        {
            gm.cubeCoins = gm.cubeCoins - gm.damageUpgradeCost;
            gm.damageUpgradePurchases = gm.damageUpgradePurchases + 1;
            gm.damageUpgradeMultiplier = gm.damageUpgradeMultiplier + 25f;
        }
    }

    public void MovementSpeedUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.movementSpeedUpgradeCost && gm.movementSpeedUpgradeMultiplier < 25)
        {
            gm.cubeCoins = gm.cubeCoins - gm.movementSpeedUpgradeCost;
            gm.movementSpeedUpgradePurchases = gm.movementSpeedUpgradePurchases + 1;
            gm.movementSpeedUpgradeMultiplier = gm.movementSpeedUpgradeMultiplier + 5f;
        }
    }
    public void HealthUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.healthUpgradeCost && gm.healthUpgradeMultiplier < 25)
        {
            gm.cubeCoins = gm.cubeCoins - gm.healthUpgradeCost;
            gm.healthUpgradePurchases = gm.healthUpgradePurchases + 1;
            gm.healthUpgradeMultiplier = gm.healthUpgradeMultiplier + 5f;
        }
    }

    public void HdtUpgradeHandler()
    {
        AudioManager.Instance.PlaySFX("UIClick");
        if (gm.cubeCoins >= gm.hdtUpgradeCost && gm.hdtUpgradeMultiplier == false)
        {
            gm.cubeCoins = gm.cubeCoins - gm.hdtUpgradeCost;
            gm.hdtUpgradePurchases = gm.hdtUpgradePurchases + 1;
            gm.hdtUpgradeMultiplier = true;
        }
    }
}
