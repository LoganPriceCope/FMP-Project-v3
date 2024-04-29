using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneTest : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("v"))
        {
          SceneManager.LoadScene("CubeClicker");
        }
    }
}
