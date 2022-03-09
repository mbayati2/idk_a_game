using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Porjectal : MonoBehaviour
{
    #region TriggersHander

    [SerializeField] BoxCollidersHandler boxCollidersHandler; 

    void Awake()
    {
        boxCollidersHandler.OnTriggerEnterH += OnChange;
    }
    #endregion
    public PowerEffect powerEffect;
    private void OnChange(bool waedads , GameObject Hit)
    {
        if(Hit == true)
        {
            Destroy(gameObject);
            powerEffect.Apply(Hit);
        }
    }
}
