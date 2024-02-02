using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuCanvas;
    [SerializeField] GameObject firstMenuButton;
    bool menuOpenCloseInput;
    bool isPaused = false;
    

    public void HandlePause(){       
        if(isPaused) unpause();
        else pause();        
    }


    void pause(){
        EventSystem.current.SetSelectedGameObject(firstMenuButton);
        isPaused = true;
        Time.timeScale = 0f;
        pauseMenuCanvas.SetActive(true);
    }

    public void unpause(){
        EventSystem.current.SetSelectedGameObject(null);
        isPaused = false;
        Time.timeScale = 1f;
        pauseMenuCanvas.SetActive(false);

    }

   



    // public void ShowPauseMenu(){
    //     if(pauseMenu.activeSelf){
    //         pauseMenu.SetActive(false);
    //         Time.timeScale = 1f;
            
    //     }
    //     else if(!pauseMenu.activeSelf){
    //         pauseMenu.SetActive(true);
    //         Time.timeScale = 0f;
    //     }
       
    // }
}
