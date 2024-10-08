using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
   public static bool Paused = false;
    public GameObject pauseMenuUI;
    // Update is called once per frame
    void Update()
    {
        if( Input.GetKeyDown(KeyCode.P)){
            if(Paused){
                Resume();
            }else{
                Pause();
            }
        }
    }
    void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }
    void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
}
