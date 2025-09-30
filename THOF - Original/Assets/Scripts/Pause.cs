using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    
    //Music source
    public AudioSource mSource;

    bool isPaused = false;

    // Start is called before the first frame update
    void Awake()
    {
        if(isPaused == false)
        {
            Time.timeScale = 1f;
        }
    }

    public void Paused()
    {
        isPaused = !isPaused;

        if(isPaused == true)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            mSource.mute = true;
            Time.timeScale = 0f;
        }

        if(isPaused == false)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            mSource.mute = false;
            Time.timeScale = 1f;
        }
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
