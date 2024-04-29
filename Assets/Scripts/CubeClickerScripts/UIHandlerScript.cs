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
        }
        else
        {
            helpMenuButton.transform.gameObject.SetActive(false);
            helpMenuActive = false;
        }
    }

    public void settingsMenuButtonFunction()
    {
        if (settingsMenuActive == false)
        {
            settingsMenuButton.transform.gameObject.SetActive(true);
            settingsMenuActive = true;
        }
        else
        {
            settingsMenuButton.transform.gameObject.SetActive(false);
            settingsMenuActive = false;
        }
    }

    public void achievementsMenuButtonFunction()
    {
        if (achievementsMenuActive == false)
        {
            achievementsMenuButton.transform.gameObject.SetActive(true);
            achievementsMenuActive = true;
        }
        else
        {
            achievementsMenuButton.transform.gameObject.SetActive(false);
            achievementsMenuActive = false;
        }
    }

    public void loadSceneTest()
    {
        SceneManager.LoadScene("CubeShooter");
    }
}
