using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator transition;
    public float transtion_time = 2f;
    public bool real = false;
    // Update is called once per frame
    public void Update()
    {
        if(real == true)
        {
            LoadNextLevel();
        }
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 2));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transtion_time);
        SceneManager.LoadScene(levelIndex);
    }
}
