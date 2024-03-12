using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public AudioSource MainSound;
    public AudioSource MySounds;
    public AudioClip HoverSound;
    public AudioClip ClickSound;
    public Image SoundButton;
    [SerializeField] public Sprite Sprite1, Sprite2;
    public void GoToScene(string SceneName)
    {
        StartCoroutine(FadeOut(MainSound, 1f));
        SceneController.instance.NextLevel();
    }

    public void MuteMusic()
    {
        if (MainSound.volume == 1f) {
            //StartCoroutine(FadeOut(MainSound, 1f));
            SoundButton.sprite = Sprite1;
            MainSound.volume = 0f;
        }
        else
        {
            //StartCoroutine(FadeIn(MainSound, 1f));
            SoundButton.sprite = Sprite2;
            MainSound.volume = 1f;
        }
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

    public IEnumerator FadeIn(AudioSource audioSource, float FadeTime)
    {
        audioSource.Play();
        float startVolume = 0;

        while (audioSource.volume < 1)
        {
            audioSource.volume += startVolume * Time.deltaTime / FadeTime;
            yield return null;
        }
    }
}
