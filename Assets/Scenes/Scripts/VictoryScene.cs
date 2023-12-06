using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Exit()
    {
        Debug.Log("BotaoSair");
        Application.Quit();
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }
}
