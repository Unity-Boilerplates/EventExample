using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewIntEventChannel", menuName = "Events/Int Event Channel", order = 1)]

public class IntEventChannel : ScriptableObject
{
    // Start is called before the first frame update
    public UnityAction<int> OnEventRaised;

    public void RaiseEvent(int value)
    {
            OnEventRaised?.Invoke(value);
    }
}
