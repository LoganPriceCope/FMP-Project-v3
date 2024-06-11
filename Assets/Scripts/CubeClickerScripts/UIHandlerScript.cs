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

    public GameObject helpMenu;
    public GameObject settingsMenu;

    Animator backgroundAnimator;

    private bool helpMenuActive = false;
    private bool settingsMenuActive = false;
    private bool achievementsMenuActive = false;


    void Start()
    {
        backgroundAnimator = gameObject.GetComponent<Animator>();
    }
    public void helpMenuButtonFunction()
    {
        if (helpMenuActive == false)
        {
            helpMenuButton.transform.gameObject.SetActive(true);
            settingsMenu.transform.gameObject.SetActive(false);
            helpMenuActive = true;
            settingsMenuActive = false;
            AudioManager.Instance.PlaySFX("UIClick");
        }
        else
        {
            helpMenuButton.transform.gameObject.SetActive(false);
            settingsMenu.transform.gameObject.SetActive(false);
            helpMenuActive = false;
            settingsMenuActive = false;
            AudioManager.Instance.PlaySFX("UIClick");
        }
    }

    public void settingsMenuButtonFunction()
    {
        if (settingsMenuActive == false)
        {
            settingsMenuButton.transform.gameObject.SetActive(true);
            helpMenu.transform.gameObject.SetActive(false);
            settingsMenuActive = true;
            helpMenuActive = false;
            AudioManager.Instance.PlaySFX("UIClick");
        }
        else
        {
            settingsMenuButton.transform.gameObject.SetActive(false);
            helpMenu.transform.gameObject.SetActive(false);
            settingsMenuActive = false;
            helpMenuActive = false;
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
      //  backgroundAnimator.SetBool("Play", true);
        
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
