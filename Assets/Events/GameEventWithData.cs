using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu]
public class GameEventWithData : ScriptableObject
{

    private readonly List<GameEventWithDataListener> eventListeners = new List<GameEventWithDataListener>();

    public void Raise(Component sender, object data)
    {
        for(int i = eventListeners.Count -1; i >= 0; i--)
            eventListeners[i].OnEventRaised(sender,data);
    }

    public void RegisterListener(GameEventWithDataListener listener)
    {
        if (!eventListeners.Contains(listener))
            eventListeners.Add(listener);
    }

    public void UnregisterListener(GameEventWithDataListener listener)
    {
        if (eventListeners.Contains(listener))
            eventListeners.Remove(listener);
    }
}
