using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonPressed : MonoBehaviour
{
    public void OnButtonClick()
    {
        Debug.Log("Button " + gameObject.name + " was clicked.");

        if(gameObject.name == "Restart"){
            SceneManager.LoadScene("MapScene");
        }
        if(gameObject.name == "MainMenu"){
            SceneManager.LoadScene("MenuScene");
        }
        if(gameObject.name == "ExitDesktop"){
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
        // Add your functionality here
    }
}
