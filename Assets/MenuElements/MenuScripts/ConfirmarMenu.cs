using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfirmarMenu : MonoBehaviour
{
    private bool ConfirmMenuIsOpen = false;
    public GameObject ConfirmMenuUI;

    public void AbrirMenu()
    {
        Abrir();
    }

    public void FecharMenu()
    {
        Fechar();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (ConfirmMenuIsOpen)
            {
                Fechar();
            }
        }
    }
    void Abrir()
    {
        ConfirmMenuIsOpen = true;
        ConfirmMenuUI.SetActive(true);
    }

    void Fechar()
    {
        ConfirmMenuIsOpen = false;
        ConfirmMenuUI.SetActive(false);
    }
}
