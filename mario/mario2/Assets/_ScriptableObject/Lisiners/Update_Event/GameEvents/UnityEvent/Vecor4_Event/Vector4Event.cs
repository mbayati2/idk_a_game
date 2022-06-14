using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Event", menuName = "ScriptibaleObject/Event_Vector4")]
public class Vector4Event : BaseGameEvent<Vector4>
{
    public void Rasise() => Rasise(new Vector4());
}

