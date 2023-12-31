using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource MainSound;
    public AudioSource MySounds;
    public AudioClip HoverSound;
    public AudioClip ClickSound;
    public void GoToScene(string SceneName)
    {
        StartCoroutine(FadeOut(MainSound, 1f));
        SceneController.instance.NextLevel();
    }

    public void QuitGame()
    {
        //Debug.Log("BotaoSair");
        //UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
        //Debug.Log("Application has quit");
    }

    public void OnHoverSound()
    {
        MySounds.PlayOneShot(HoverSound);
    }
    public void OnClickSound()
    {
        MySounds.PlayOneShot(ClickSound);
    }
    public void MenuScene()
    {
        SceneManager.LoadScene("MenuPrincipal");
    }

    public IEnumerator FadeOut(AudioSource audioSource, float FadeTime)
    {
        float startVolume = audioSource.volume;

        while (audioSource.volume > 0)
        {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }

        audioSource.Stop();
    }
}
