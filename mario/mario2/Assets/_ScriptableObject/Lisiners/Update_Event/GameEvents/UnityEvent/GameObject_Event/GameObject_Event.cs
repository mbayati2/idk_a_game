using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptibaleObject/Event_GameObejct")]
public class GameObject_Event : BaseGameEvent<GameObject>
{
    public void Rasise() => Rasise(new GameObject());
}

