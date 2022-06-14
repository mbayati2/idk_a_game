using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptibaleObject/Event_bool")]
public class boolEvent : BaseGameEvent<bool>
{
    public void Rasise() => Rasise(new bool());
}

