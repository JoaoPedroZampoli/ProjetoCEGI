using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsMainMenuScript : MonoBehaviour
{
    public string WhichMenuIsOpen;
    public GameObject SettingsMenu;
    public GameObject ButtonsMenu;
    public GameObject CreditsMenu;

    public void OpenSettings()
    {
        AbrirSettings();
    }

    public void CloseSettings()
    {
        FecharSettings();
    }

    public void OpenButtons()
    {
        AbrirButtons();
    }

    public void CloseButtons()
    {
        FecharButtons();
    }
   
    public void OpenCredits()
    {
        AbrirCredits();
    }

    public void CloseCredits()
    {
        FecharCredits();
    }

    public void AbrirGithub(string Nome)
    {
        switch (Nome)
        {
            case "Joao":
                Application.OpenURL("https://github.com/JoaoPedroZampoli");
            break;
            case "Vitoria":
                Application.OpenURL("https://github.com/Victoriasemc1");
            break;
            case "Davi":
                Application.OpenURL("https://github.com/Yagamikk");
            break;
            case "ProjetoCEGI":
                Application.OpenURL("https://github.com/JoaoPedroZampoli/ProjetoCEGI");
            break;

        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (WhichMenuIsOpen != "")
            {
                CloseMenu(WhichMenuIsOpen);
            }
        }
        
    }

    void CloseMenu(string WhichMenu)
    {
        switch (WhichMenu)
        {
            case "Settings":
                CloseSettings();
            break;
            case "Buttons":
                CloseButtons();
            break;
            case "Credits":
                CloseCredits();
            break;
        }
    }

    void AbrirSettings()
    {
        WhichMenuIsOpen = "Settings";
        SettingsMenu.SetActive(true);
    }

    void AbrirButtons()
    {
        WhichMenuIsOpen = "Buttons";
        ButtonsMenu.SetActive(true);
    }

    void AbrirCredits()
    {
        WhichMenuIsOpen = "Credits";
        CreditsMenu.SetActive(true);
    }

    void FecharSettings()
    {
        SettingsMenu.SetActive(false);
        WhichMenuIsOpen = "";
    }

    void FecharButtons()
    {
        ButtonsMenu.SetActive(false);
        WhichMenuIsOpen = "Settings";
    }

    void FecharCredits()
    {
        CreditsMenu.SetActive(false);
        WhichMenuIsOpen = "Settings";
    }
}
