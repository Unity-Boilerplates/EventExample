using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CallPause : MonoBehaviour
{
    [SerializeField] GameEvent pause;
    
    public void OnPause(InputAction.CallbackContext context){
        
        if(context.performed) {
            pause.Raise();
        }
    }
}
