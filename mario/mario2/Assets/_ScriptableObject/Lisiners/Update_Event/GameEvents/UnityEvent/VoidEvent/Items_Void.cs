using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Items_Void<T , E , UER> : BaseGameEvent<T> where UER : UnityEvent<T>
    
{
    [SerializeField] private E gameEvent;
    public E GameEvent { get{ return gameEvent; } set { gameEvent = value;} } 

    [SerializeField] public UER unityEventRespon;
    
}
