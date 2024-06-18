using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void startbt()
    {
        SceneManager.LoadScene("onlyLevel");
    }

    public void info()
    {
        SceneManager.LoadScene("info");
    }
    public void tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void settings()
    {
        SceneManager.LoadScene("settings");
    }
   

    public void Quit()
    {
        Application.Quit();
    }



}

