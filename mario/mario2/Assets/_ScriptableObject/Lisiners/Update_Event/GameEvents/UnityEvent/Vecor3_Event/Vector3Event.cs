using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptibaleObject/Event_Vector3")]
public class Vector3Event : BaseGameEvent<Vector3>
{
    public void Rasise() => Rasise(new Vector3());
}

