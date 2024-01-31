using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewVoidEventChannel", menuName = "Events/Void Event Channel", order = 1)]
public class VoidEventChannel : ScriptableObject
{
   public UnityAction OnEventRaised;

   public void RaiseEvent()
   {
         OnEventRaised?.Invoke();
   }
}