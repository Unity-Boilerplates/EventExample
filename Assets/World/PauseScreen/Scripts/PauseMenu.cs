using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
public class PauseMenu : MonoBehaviour
{
    [SerializeField] GameObject pauseMenuCanvas;
    [SerializeField] GameObject firstMenuButton;
    bool menuOpenCloseInput;
    bool isPaused = false;
    PlayerInput input;
    
    void Start(){
        input = GetComponent<PlayerInput>();
    }
    public void HandlePause(InputAction.CallbackContext context){
        if(context.performed){
            if(isPaused) unpause();
            else pause();
        }
        
    }


    void pause(){
        input.SwitchCurrentActionMap("UI");
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
        input.SwitchCurrentActionMap("Player");

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
