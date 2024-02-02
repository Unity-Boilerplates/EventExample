using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PauseMenu menu;
    [SerializeField] GameEvent pauseEvent;

     public void ResumeButton(){
        pauseEvent.Raise();
    }

    public void RestartButton(){
        pauseEvent.Raise();
        int scene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(scene, LoadSceneMode.Single);    
    }

    public void ExitButton(){
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
        Application.Quit();
    }


}
