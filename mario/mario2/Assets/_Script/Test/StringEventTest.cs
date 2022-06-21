using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringEventTest : MonoBehaviour
{
    [SerializeField] private string wow;
    [SerializeField] private string huh;


    [SerializeField] private StringEvent stringEvent;

    private void Awake() {
        
        stringEvent.Rasise(huh);


    }

    public void YEP(string wow2)
    {
        wow = wow2;
    }
}
