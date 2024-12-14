using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagementScript : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Lvl1");
    }
    
    public void OptionsButton()
    {
        SceneManager.LoadScene("Options");
    }
    
    public void BackButton()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
