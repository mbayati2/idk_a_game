using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptibaleObject/Event_String")]
public class StringEvent : BaseGameEvent<string>
{
    public void Rasise() => Rasise(new char[100].ToString());
}

