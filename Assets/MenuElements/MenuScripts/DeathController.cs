using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathController : MonoBehaviour
{
    public Animator Transition;
    public float TransitionTime = 1f;

    public void Restart()
    {
        ReloadLevel();
    }

    public void ExitGame()
    {
        QuitGameSelected();
    }
    void Update()
    {
        /*
         *if(Input.GetMouseButtonDown(0))
         *{
         *  QuitGameSelected();
         *}
         */
    }

    public void ReloadLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }
    IEnumerator LoadLevel(int LevelIndex)
    {
        Transition.SetTrigger("IniciarTransicao");
        yield return new WaitForSeconds(TransitionTime);
        SceneManager.LoadScene(LevelIndex);
    }

    public void QuitGameSelected()
    {
        StartCoroutine(QuitGame(SceneManager.GetActiveScene().buildIndex - 2));
    }
    IEnumerator QuitGame(int LevelIndex)
    {
        Transition.SetTrigger("IniciarTransicao");
        yield return new WaitForSeconds(TransitionTime);
        SceneManager.LoadScene(LevelIndex);
    }
}
