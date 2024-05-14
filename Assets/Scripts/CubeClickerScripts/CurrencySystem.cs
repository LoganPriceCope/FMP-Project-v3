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

    // Upgrades Tapper
    public float tapperUpgradePurchases = 1f;
    public float tapperUpgradeMultiplier = 1f;
    public float tapperUpgradeCostBoost;
    public Text tapperUpgradeCostText;
    public Text tapperUpgradeMultiplierText;
    public float tapperUpgradeCost = 10f;

    // Upgrades Helping Hand
    public float helpingHandUpgradePurchases = 0f;
    public float helpingHandUpgradeMultiplier = 0f;
    public float helpingHandUpgradeCostBoost;
    public Text helpingHandUpgradeCostText;
    public Text helpingHandUpgradeMultiplierText;
    public float helpingHandUpgradeCost = 10f;

    // Upgrades Super Tapper
    public float superTapperUpgradePurchases = 0f;
    public float superTapperUpgradeMultiplier = 0f;
    public float superTapperUpgradeCostBoost;
    public Text superTapperUpgradeCostText;
    public Text superTapperUpgradeMultiplierText;
    public float superTapperUpgradeCost = 10f;

    // Upgrades Tapping Factory
    public float tappingFactoryUpgradePurchases = 0f;
    public float tappingFactoryUpgradeMultiplier = 0f;
    public float tappingFactoryUpgradeCostBoost;
    public Text tappingFactoryUpgradeCostText;
    public Text tappingFactoryUpgradeMultiplierText;
    public float tappingFactoryUpgradeCost = 10f;

    // Upgrades Tapping Universe
    public float tappingUniverseUpgradePurchases = 0f;
    public float tappingUniverseUpgradeMultiplier = 0f;
    public float tappingUniverseUpgradeCostBoost;
    public Text tappingUniverseUpgradeCostText;
    public Text tappingUniverseUpgradeMultiplierText;
    public float tappingUniverseUpgradeCost = 10f;

    public float coinCounter = 0f;
    public float multiplier;

    public Text coinCount;
    public Text coinsPerClick;

    GameManagerScript gm;

    private void Start()
    {
        gm = GameManagerScript.instance;
        
    }

    private void Update()
    {

        coinCount.text = coinCounter+"";
        multiplier = 1 + (helpingHandUpgradeMultiplier + superTapperUpgradeMultiplier + tappingFactoryUpgradeMultiplier + tappingUniverseUpgradeMultiplier) * tapperUpgradeMultiplier;
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
        if (gm.reloadUpgradePurchases < 5)
        {
            reloadUpgradeCostText.text = "[" + gm.reloadUpgradeCost + "c]";
            reloadUpgradeMultiplierText.text = gm.reloadUpgradeMultiplier + "/S >" + (gm.reloadUpgradeMultiplier - 0.5f) + "/S";
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
        tapperUpgradeCostBoost = tapperUpgradePurchases * 10;
        if (tapperUpgradePurchases > 1)
        {
            tapperUpgradeCost = 50f * tapperUpgradePurchases * tapperUpgradePurchases * tapperUpgradePurchases * tapperUpgradePurchases;
        }
        else
        {
            tapperUpgradeCost = 50f * tapperUpgradePurchases;
        }
        tapperUpgradeCostText.text = "Tapper [" + tapperUpgradeCost + "c]";
        tapperUpgradeMultiplierText.text = "x"+tapperUpgradeMultiplier;

        // Helping hand upgrade costs
        helpingHandUpgradeCostBoost = helpingHandUpgradePurchases * 10 + 10;
        if (helpingHandUpgradePurchases >= 1)
        {
            helpingHandUpgradeCost = 10f * helpingHandUpgradePurchases * 1.2f;
        }
        else
        {
            helpingHandUpgradeCost = 10f;
        }
        helpingHandUpgradeCostText.text = "Helping Hand [" + helpingHandUpgradeCost + "c]";
        helpingHandUpgradeMultiplierText.text = "+" + helpingHandUpgradeMultiplier;

        // Super tapper upgrade costs
        superTapperUpgradeCostBoost = superTapperUpgradePurchases * 10 + 10;
        if (superTapperUpgradePurchases >= 1)
        {
            superTapperUpgradeCost = 500f * superTapperUpgradePurchases * 1.4f;
        }
        else
        {
            superTapperUpgradeCost = 500f;
        }
        superTapperUpgradeCostText.text = "Super Tapper [" + superTapperUpgradeCost + "c]";
        superTapperUpgradeMultiplierText.text = "+" + superTapperUpgradeMultiplier;

        // Tapping factory upgrade costs
        tappingFactoryUpgradeCostBoost = tappingFactoryUpgradePurchases * 10 + 10;
        if (tappingFactoryUpgradePurchases >= 1)
        {
            tappingFactoryUpgradeCost = 10000f * tappingFactoryUpgradePurchases * 1.5f;
        }
        else
        {
            tappingFactoryUpgradeCost = 10000f;
        }
        tappingFactoryUpgradeCostText.text = "Tapping Factory [" + tappingFactoryUpgradeCost + "c]";
        tappingFactoryUpgradeMultiplierText.text = "+" + tappingFactoryUpgradeMultiplier;

        // Tapping Universe upgrade costs
        tappingUniverseUpgradeCostBoost = tappingUniverseUpgradePurchases * 10 + 10;
        if (tappingUniverseUpgradePurchases >= 1)
        {
            tappingUniverseUpgradeCost = 1000000f * tappingUniverseUpgradePurchases * 1.6f;
        }
        else
        {
            tappingUniverseUpgradeCost = 1000000f;
        }
        tappingUniverseUpgradeCostText.text = "Tapping Universe [" + tappingUniverseUpgradeCost + "c]";
        tappingUniverseUpgradeMultiplierText.text = "+" + tappingUniverseUpgradeMultiplier;
    }


    // || CUBE CLICKER UPGADES ||
    public void tapperUpgradeHandler()
    {
        if (coinCounter >= tapperUpgradeCost)
        {
            
            coinCounter = coinCounter - tapperUpgradeCost;
            tapperUpgradePurchases = tapperUpgradePurchases + 1;
            tapperUpgradeMultiplier = tapperUpgradeMultiplier + 1;
            
        }
    }

    public void helpingHandUpgradeHandler()
    {
        if (coinCounter >= helpingHandUpgradeCost)
        {
            coinCounter = coinCounter - helpingHandUpgradeCost;
            helpingHandUpgradePurchases = helpingHandUpgradePurchases + 1;
            helpingHandUpgradeMultiplier = helpingHandUpgradeMultiplier + 1;
        }
    }

    public void superTapperUpgradeHandler()
    {
        if (coinCounter >= superTapperUpgradeCost)
        {
            coinCounter = coinCounter - superTapperUpgradeCost;
            superTapperUpgradePurchases = superTapperUpgradePurchases + 1;
            superTapperUpgradeMultiplier = superTapperUpgradeMultiplier + 10;
        }
    }

    public void tappingFactoryUpgradeHandler()
    {
        if (coinCounter >= tappingFactoryUpgradeCost)
        {
            coinCounter = coinCounter - tappingFactoryUpgradeCost;
            tappingFactoryUpgradePurchases = tappingFactoryUpgradePurchases + 1;
            tappingFactoryUpgradeMultiplier = tappingFactoryUpgradeMultiplier + 100;
        }
    }

    public void tappingUniverseUpgradeHandler()
    {
        if (coinCounter >= tappingUniverseUpgradeCost)
        {
            coinCounter = coinCounter - tappingUniverseUpgradeCost;
            tappingUniverseUpgradePurchases = tappingUniverseUpgradePurchases + 1;
            tappingUniverseUpgradeMultiplier = tappingUniverseUpgradeMultiplier + 1000;
        }
    }

    public void AddCube()
    {
        coinCounter = coinCounter + multiplier;
    }

    // || FIRST PERSON SHOOTER UPGRADES ||
    public void ReloadSpeedUpgradeHandler()
    {
        if (coinCounter >= gm.reloadUpgradeCost && gm.reloadUpgradeMultiplier > 4)
        {
            coinCounter = coinCounter - gm.reloadUpgradeCost;
            gm.reloadUpgradePurchases = gm.reloadUpgradePurchases + 1;
            gm.reloadUpgradeMultiplier = gm.reloadUpgradeMultiplier - 0.5f;
        }
    }

    public void DamageUpgradeHandler()
    {
        if (coinCounter >= gm.damageUpgradeCost && gm.damageUpgradeMultiplier < 100)
        {
            coinCounter = coinCounter - gm.damageUpgradeCost;
            gm.damageUpgradePurchases = gm.damageUpgradePurchases + 1;
            gm.damageUpgradeMultiplier = gm.damageUpgradeMultiplier + 25f;
        }
    }

    public void MovementSpeedUpgradeHandler()
    {
        if (coinCounter >= gm.movementSpeedUpgradeCost && gm.movementSpeedUpgradeMultiplier < 25)
        {
            coinCounter = coinCounter - gm.movementSpeedUpgradeCost;
            gm.movementSpeedUpgradePurchases = gm.movementSpeedUpgradePurchases + 1;
            gm.movementSpeedUpgradeMultiplier = gm.movementSpeedUpgradeMultiplier + 5f;
        }
    }
    public void HealthUpgradeHandler()
    {
        if (coinCounter >= gm.healthUpgradeCost && gm.healthUpgradeMultiplier < 25)
        {
            coinCounter = coinCounter - gm.healthUpgradeCost;
            gm.healthUpgradePurchases = gm.healthUpgradePurchases + 1;
            gm.healthUpgradeMultiplier = gm.healthUpgradeMultiplier + 5f;
        }
    }

    public void HdtUpgradeHandler()
    {
        if (coinCounter >= gm.hdtUpgradeCost && gm.hdtUpgradeMultiplier == false)
        {
            coinCounter = coinCounter - gm.hdtUpgradeCost;
            gm.hdtUpgradePurchases = gm.hdtUpgradePurchases + 1;
            gm.hdtUpgradeMultiplier = true;
        }
    }
}
