using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrencySystem : MonoBehaviour
{

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

    private void Update()
    {

        coinCount.text = coinCounter+"";
        multiplier = 1 + (helpingHandUpgradeMultiplier + superTapperUpgradeMultiplier + tappingFactoryUpgradeMultiplier + tappingUniverseUpgradeMultiplier) * tapperUpgradeMultiplier;
        coinsPerClick.text = multiplier + "c/click";

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
}
