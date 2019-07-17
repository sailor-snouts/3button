using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    private VideoPlayer splash;

    void Start()
    {
        splash = GetComponent<VideoPlayer>();
        splash.loopPointReached += EndReached;    
    }

    void Update() {
        // Any button press goes here to advance
    }

    void EndReached(VideoPlayer vplayer) 
    {
        SceneManager.LoadScene("Main");
    }    
}
