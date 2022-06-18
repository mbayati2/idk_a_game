using UnityEngine;
using System.Collections;

public class Test : Hp_Entetis
{
    public int Hp_Amount;
    public override int current_Hp { get => Hp_Amount; set => Hp_Amount = value; }

}