using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CallPause : MonoBehaviour
{
    [SerializeField] GameEvent pause;
    

    void Update(){
        Debug.Log(Time.timeScale);
    }
    public void OnPause(InputAction.CallbackContext context){
        
        if(context.performed) {
            pause.Raise();
        }
    }
}
