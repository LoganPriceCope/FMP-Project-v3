using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{

    public GameObject pauseScreen;
    public GameObject mainMenu;
    public GameObject resume;
    public bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(paused == false)
            {
                pause();
            } 
        }
    }

    public void pause()
    {
        paused = true;
        pauseScreen.SetActive(true);
        Time.timeScale = 0;
    //    Time.fixedTime = 0;
        Cursor.lockState = CursorLockMode.None;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("StartMenu");
        paused = false;
    }

    public void ResumeGame()
    {
        paused = false;
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
