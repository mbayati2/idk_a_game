using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseGameEvent<T> : ScriptableObject
{
    private readonly List<IGameEventListener<T>> eventListeners = new List<IGameEventListener<T>>();

    public void Rasise(T item)
    {
        for (int i = eventListeners.Count - 1; i >= 0 ; i--)
        {
            eventListeners[i].OnEventRaise(item);
        }
    }
    public void RegisterListener(IGameEventListener<T> listener)
    {
        if (!eventListeners.Contains(listener))
        {
            eventListeners.Add(listener);
        }
    }
    public void UnregisterListener(IGameEventListener<T> listener)
    {
          if (eventListeners.Contains(listener))
        {
            eventListeners.Remove(listener);
        }
    }
}
