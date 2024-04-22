using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script is used to handle the main functionalitys of the game, which are used more than once. Its also important for major systems like Audio and Scenes to work.

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }



}
