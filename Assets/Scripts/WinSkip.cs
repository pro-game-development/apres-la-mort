using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class WinSkip : MonoBehaviour
{
    public void LoadScene(string WinScene)
    {
        SceneManager.LoadScene("MainMenu");
    }
}