using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Launcher : MonoBehaviour
{
    public GameObject main;
    public GameObject settings;
    public GameObject controls;

    public Button continueBtn;

    public Stats stats;
    public moving player;

    private void Start()
    {
        PlayerData data = new PlayerData();
        if(data.saved == true)
        {
            //PlayerPrefs.GetString("saved", "1");
            continueBtn.interactable = true;
            Debug.Log("able to load save");
        }
        else if(data.saved == false)
        {
            continueBtn.interactable = false;
            Debug.Log("not able to load save");
        }
    }

    public void Continue()
    {
        SceneManager.LoadScene(1);
    }

    public void NewGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        CloseAllTabs();
        main.SetActive(true);
    }

    public void Settings()
    {
        CloseAllTabs();
        settings.SetActive(true);
    }
    public void Controls()
    {
        CloseAllTabs();
        controls.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void CloseAllTabs()
    {
        settings.SetActive(false);
        main.SetActive(false);
        controls.SetActive(false);
    }
}
