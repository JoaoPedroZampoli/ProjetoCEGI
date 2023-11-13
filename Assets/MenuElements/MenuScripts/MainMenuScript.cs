using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
   public void GoToScene(string SceneName)
    {
        SceneManager.LoadScene(SceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application has quit");
    }

    public AudioSource MySounds;
    public AudioClip HoverSound;
    public AudioClip ClickSound;

    public void OnHoverSound()
    {
        MySounds.PlayOneShot(HoverSound);
    }
    public void OnClickSound()
    {
        MySounds.PlayOneShot(ClickSound);
    }
}
