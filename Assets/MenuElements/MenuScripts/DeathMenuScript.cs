using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenuScript : MonoBehaviour
{
    public AudioSource MainSound;
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
