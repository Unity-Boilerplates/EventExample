using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CallPause : MonoBehaviour
{
    [SerializeField] GameEvent pause;
    bool paused = false;
    PlayerInput input;


    void Start(){
        input = GetComponent<PlayerInput>();
    }
    void Update(){
        Debug.Log(Time.timeScale);
    }
    public void OnPause(InputAction.CallbackContext context){
        
        if(context.performed) {
            
            pause.Raise();
            if(paused) {
                paused = false;
                input.SwitchCurrentActionMap("Player");

                
            }
            else {
                paused = true;
                input.SwitchCurrentActionMap("UI");
            }
        }
    }
}
