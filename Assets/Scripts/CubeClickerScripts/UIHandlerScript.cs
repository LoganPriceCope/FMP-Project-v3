using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class UIHandlerScript : MonoBehaviour
{
    public GameObject helpMenuButton;
    public GameObject settingsMenuButton;
    public GameObject achievementsMenuButton;

    private bool helpMenuActive = false;
    private bool settingsMenuActive = false;
    private bool achievementsMenuActive = false;

    public void helpMenuButtonFunction()
    {
        if (helpMenuActive == false)
        {
            helpMenuButton.transform.gameObject.SetActive(true);
            helpMenuActive = true;
            AudioManager.Instance.PlaySFX("UIClick");
        }
        else
        {
            helpMenuButton.transform.gameObject.SetActive(false);
            helpMenuActive = false;
            AudioManager.Instance.PlaySFX("UIClick");
        }
    }

    public void settingsMenuButtonFunction()
    {
        if (settingsMenuActive == false)
        {
            settingsMenuButton.transform.gameObject.SetActive(true);
            settingsMenuActive = true;
            AudioManager.Instance.PlaySFX("UIClick");
        }
        else
        {
            settingsMenuButton.transform.gameObject.SetActive(false);
            settingsMenuActive = false;
            AudioManager.Instance.PlaySFX("UIClick");
        }
    }

    public void achievementsMenuButtonFunction()
    {
        if (achievementsMenuActive == false)
        {
            achievementsMenuButton.transform.gameObject.SetActive(true);
            achievementsMenuActive = true;
            AudioManager.Instance.PlaySFX("UIClick");
        }
        else
        {
            achievementsMenuButton.transform.gameObject.SetActive(false);
            achievementsMenuActive = false;
            AudioManager.Instance.PlaySFX("UIClick");
        }
    }

    public void loadSceneTest()
    {
        SceneManager.LoadScene("CubeShooter");
    }

    public void loadCubeClicker()
    {
        SceneManager.LoadScene("CubeClicker");
    }
    public void loadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }

    public void leave()
    {
        Application.Quit();
    }
}
