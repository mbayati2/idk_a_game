using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptibaleObject/Event_Void")]
public class VoidEvent : BaseGameEvent<Void>
{
    public void Rasise() => Rasise(new Void());
}

